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
        string path = " ";
        _Excel.Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }


        public void WriteToCell(int i, int j, string word, string type, string meaning)
        {
            ws.Cells[i, j].Value2 = word;
            ws.Cells[i, j + 1].Value2 = type;
            ws.Cells[i, j + 2].Value2 = meaning;
        }
        public void Save()
        {
            wb.Save();
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
        public void Close()
        {
            wb.Close();
        }
        public void Quit()
        {
            excel.Quit();
        }

    }
}
