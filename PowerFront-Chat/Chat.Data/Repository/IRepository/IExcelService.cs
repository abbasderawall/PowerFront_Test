using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data.Repository.IRepository
{
    public interface IExcelService
    {
        public MemoryStream ExportSchoolStaff<T>(List<T> dataList, List<string> excelColumns, string sheetName = "Sheet1");
    }
}
