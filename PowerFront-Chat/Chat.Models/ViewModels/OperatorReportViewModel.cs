using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Models.ViewModels
{
    public class OperatorReportViewModel
    {
        public int OperatorID { get; set; }
        public string Name { get; set; }
        public int ProactiveSent { get; set; }
        public int ProactiveAnswered { get; set; }
        public int ProactiveResponseRate { get; set; }
        public int ReactiveReceived { get; set; }
        public int ReactiveAnswered { get; set; }
        public int ReactiveResponseRate { get; set; }
        public string TotalChatLength { get; set; }
        public string AverageChatLength { get; set; }
    }

    public class filter
    {
        public int value { get; set; }
        public string Text  { get; set; }
    }
    public class OperatorReportItems
    {
        public Conversation Conversation { get; set; }
        public Visitor Visitor { get; set; }
        public ICollection<OperatorReportViewModel> OperatorProductivity { get; set; }
        public IEnumerable<SelectListItem> WebSiteList { get; set; }
        public IEnumerable<SelectListItem> DeviceList { get; set; }
        public IEnumerable<SelectListItem> PreDefineFilter { get; set; }
        public filter PreDefineFilterValue { get; set; }

    }
   
}
