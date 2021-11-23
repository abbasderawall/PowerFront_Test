using Chat.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;
using OfficeOpenXml.Style.XmlAccess;
using Newtonsoft.Json;
using System.Drawing;

namespace Chat.Data.Repository
{
    public class ExcelService : IExcelService
    {
        public MemoryStream ExportSchoolStaff<T>(List<T> dataList, List<string> excelColumns,  string sheetName = "Sheet1")
        {
           
            DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(dataList), (typeof(DataTable)));
            var memory = new MemoryStream();
            using (var package = new ExcelPackage(memory))
            {
                int count = 1;
                var workSheet = package.Workbook.Worksheets.Add(sheetName);
                Color OrangeTextColor = ColorTranslator.FromHtml("#EB5B41");           
                workSheet.Protection.AllowFormatColumns = true;
                workSheet.Protection.AllowEditScenarios = true;
                workSheet.TabColor = System.Drawing.Color.White;
                // Header of the Excel sheet
                workSheet.Row(1).Style.WrapText = true;
                workSheet.Row(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                workSheet.Row(1).Height = 50;
                workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Row(1).Style.Font.Size = 12;
                workSheet.Row(1).Style.Font.Name = "Avenir Book";
                workSheet.Row(1).Style.Font.Bold = true;
                workSheet.Row(1).Style.Font.Color.SetColor(Color.White);

                foreach (var column in excelColumns)
                {
                    workSheet.Cells[1, count].Value = column;
                    if (workSheet.Cells.Value != null)
                        workSheet.Cells.Style.Locked = false;
                    count++;
                }
                workSheet.Row(1).Height = 35;
                workSheet.Row(1).Style.Locked = true;
              
                // Header Color
           
                Color colFK = ColorTranslator.FromHtml("#53B5E0");
                workSheet.Cells[$"A{1}:Z{1}"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                workSheet.Cells[$"A{1}:Z{1}"].Style.Fill.BackgroundColor.SetColor(colFK);
                      
                int recordIndex = 2;
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in table.Rows)
                    {
                        workSheet.Cells[recordIndex, 1].Value = dataRow["OperatorID"].ToString();
                        workSheet.Cells[recordIndex, 2].Value = dataRow["Name"].ToString();
                        workSheet.Cells[recordIndex, 3].Value = dataRow["ProactiveSent"].ToString();
                        workSheet.Cells[recordIndex, 4].Value = dataRow["ProactiveAnswered"].ToString();                        
                        workSheet.Cells[recordIndex, 5].Value = dataRow["ProactiveResponseRate"].ToString();                  
                        workSheet.Cells[recordIndex, 6].Value = dataRow["ReactiveReceived"].ToString();              
                        workSheet.Cells[recordIndex, 7].Value = dataRow["ReactiveAnswered"].ToString();
                        workSheet.Cells[recordIndex, 8].Value = dataRow["ReactiveResponseRate"].ToString();                    
                        workSheet.Cells[recordIndex, 9].Value = dataRow["TotalChatLength"].ToString();          
                        workSheet.Cells[recordIndex, 10].Value = dataRow["AverageChatLength"].ToString();
                        recordIndex++;
                    }
                  
                }
                workSheet.Cells.Style.Font.Size = 12;
                workSheet.Cells.Style.Font.Name = "Avenir Book";
                workSheet.DefaultRowHeight = 20;
                workSheet.Column(1).Width = 30;
                workSheet.Column(2).Width = 30;
                workSheet.Column(3).Width = 30;
                workSheet.Column(4).Width = 30;
                workSheet.Column(5).Width = 30;
                workSheet.Column(6).Width = 30;
                workSheet.Column(7).Width = 30;
                workSheet.Column(8).Width = 30;
                workSheet.Column(9).Width = 30;
                workSheet.Column(10).Width = 30;
                package.Save();
            }
            memory.Position = 0;
            return memory;
        }
    }
}
