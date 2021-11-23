using Chat.Data.Repository;
using Chat.Data.Repository.IRepository;
using Chat.Models;
using Chat.Models.ViewModels;
using Chat.Utility;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Ares.OPReport.Controllers
{
    [Area("OPReport")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unifOfWork;
        private readonly IExcelService excelService;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unifOfWork, IExcelService excelService)
        {
            _logger = logger;
            _unifOfWork = unifOfWork;
            this.excelService = excelService;
        }

        public IActionResult Index()
        {
           
            OperatorReportItems items = new OperatorReportItems()
            {

                OperatorProductivity = _unifOfWork.SP_Call.List<OperatorReportViewModel>(PUtilities.Proc_GetOperatorProductivity, null).ToList(),
                Visitor = new Visitor(),
                DeviceList = _unifOfWork.Visitor.GetAll().Distinct().Select(i => new SelectListItem
                {
                    Text = i.Device,
                    Value = i.Device.ToString()
                }).Distinct(),
                Conversation = new Conversation(),
                WebSiteList = _unifOfWork.Conversation.GetAll().Distinct().Select(i => new SelectListItem
                {
                    Text = i.Website,
                    Value = i.Website.ToString()
                }).Distinct(),      
                PreDefineFilter = AddFilter().Select(i => new SelectListItem
                {
                    Text = i.Text,
                    Value = i.value.ToString()
                })
            };
            // IEnumerable <OperatorReportViewModel> reportData = _unifOfWork.SP_Call.List<OperatorReportViewModel>(PUtilities.Proc_GetOperatorProductivity, null);         
            return View(items);
        }

        [HttpPost]
        public IActionResult Index(OperatorReportItems operatorReportItems)
        {
        
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@webSite", operatorReportItems.Conversation.Website, DbType.String, ParameterDirection.Input);
            parameter.Add("@device", operatorReportItems.Visitor.Device, DbType.String, ParameterDirection.Input);
            parameter.Add("@preDefine", operatorReportItems.PreDefineFilterValue.value, DbType.Int32, ParameterDirection.Input);
            parameter.Add("@fromDate", operatorReportItems.Conversation.StartDate, DbType.DateTime, ParameterDirection.Input);
            parameter.Add("@toDate", operatorReportItems.Conversation.EndDate, DbType.DateTime, ParameterDirection.Input);
           
            OperatorReportItems items = new OperatorReportItems()
            {            
             OperatorProductivity = _unifOfWork.SP_Call.List<OperatorReportViewModel>(PUtilities.Proc_GetOperatorProductivity, parameter).ToList(),
                Visitor = new Visitor(),
                DeviceList = _unifOfWork.Visitor.GetAll().Distinct().Select(i => new SelectListItem
                {
                    Text = i.Device,
                    Value = i.Device.ToString()
                }).Distinct(),
                Conversation = new Conversation(),
                WebSiteList = _unifOfWork.Conversation.GetAll().Distinct().Select(i => new SelectListItem
                {
                    Text = i.Website,
                    Value = i.Website.ToString()
                }).Distinct(),
                PreDefineFilter = AddFilter().Select(i => new SelectListItem
                {
                    Text = i.Text,
                    Value = i.value.ToString()
                })
            };                    
            return View(items);
        }
        public List<filter> AddFilter()
        {
            List<filter> filter = new List<filter>();
           
            foreach (var item in Enum.GetValues(typeof(PUtilities.PreDefinefilter)))
            {
                var list = new filter
                {
                    value = (int)item,
                    Text = item.ToString()
                };
                filter.Add(list);
            }
            return filter;
        }    
        public IActionResult Export()
        {    
                OperatorReportItems items = new OperatorReportItems()
                {
                    OperatorProductivity = _unifOfWork.SP_Call.List<OperatorReportViewModel>(PUtilities.Proc_GetOperatorProductivity, null).ToList()
                };         
                Stream stream = null;
                var EXCEL_TYPE = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                stream = excelService.ExportSchoolStaff(items.OperatorProductivity.ToList(), PUtilities.GetExcelColumns().ToList(), "Report List");
                if (stream == null)
                    return NotFound("Record not found");

                return File(stream, EXCEL_TYPE, "Report List.xlsx");
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            OperatorReportItems items = new OperatorReportItems()
            {
                OperatorProductivity = _unifOfWork.SP_Call.List<OperatorReportViewModel>(PUtilities.Proc_GetOperatorProductivity, null).ToList()
            };
            return Json(new { data = items.OperatorProductivity });
        }
        #endregion
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
