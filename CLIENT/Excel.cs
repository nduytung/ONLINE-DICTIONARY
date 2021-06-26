using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Excel = Microsoft.Office.Interop.Excel;

namespace CLIENT
{
    class Excel
    {
        #region VariableDeclare
        string path = " ";
        _Excel.Application excel = new _Excel.Application();
        Workbook workbook;
        Worksheet worksheet;
        #endregion

        #region InitializeExcelReference
        public Excel(string path, int sheet)
        {
            this.path = path;
            workbook = excel.Workbooks.Open(path);
            worksheet = workbook.Worksheets[sheet];
        }
        #endregion

        #region ExcelControl

        public void WriteToCell(int row, int col, string word, string type, string meaning)
        {
            worksheet.Cells[row, col].Value2 = word;
            worksheet.Cells[row, col + 1].Value2 = type;
            worksheet.Cells[row, col + 2].Value2 = meaning;
        }

        public void Save()
        {
            workbook.Save();
        }

        public void SaveAs(string path)
        {
            workbook.SaveAs(path);
        }

        public void Close()
        {
            workbook.Close();
        }
        #endregion
    }
}
