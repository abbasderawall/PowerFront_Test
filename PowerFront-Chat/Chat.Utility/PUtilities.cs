using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Utility
{
    public static class PUtilities
    {
        public const string Proc_GetOperatorProductivity = "OperatorProductivity";

        public enum PreDefinefilter
        {
            [Description("Today")]
            Today = -1,
            [Description("Yesterday")]
            Yesterday = -2,
            [Description("This Week")]
            ThisWeek = -7,
            [Description("Last Week")]
            LastWeek = -14,
            [Description("This Month")]
            ThisMonth = -30,
            [Description("This Year")]
            ThisYear = -365,
            [Description("Last Year")]
            LastYear = -730,
        }
        public static List<string> GetExcelColumns()
        {
            var columnlist = new List<string>();

                columnlist.Add("Sr.NO");
                columnlist.Add("Name");
                columnlist.Add("Proactive Sent");
                columnlist.Add("Proactive Answered");
                columnlist.Add("Proactive Response Rate");
                columnlist.Add("Reactive Received");
                columnlist.Add("Reactive Answered");
                columnlist.Add("Reactive Response Rate");
                columnlist.Add("Total Chat Length");
                columnlist.Add("Average Chat Length");                    
            return columnlist;
        }

    }
}
