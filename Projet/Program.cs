using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;
using _excel = Microsoft.Office.Interop.Excel;
namespace Excel_with_C_Sharp
{
    class Excel
    {
        // Create an excel application object, workbook oject and worksheet object
        _Application excel = new _excel.Application();
        Workbook workbook;
        Worksheet worksheet;

        // Method creates a new Excel file by creating a new Excel workbook with a single worksheet
        public void NewFile()
        {
            this.workbook = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.worksheet = this.workbook.Worksheets[1];
        }

        // Method adds a new worksheet to the existing workbook 
        public void NewSheet()
        {
            Worksheet newSheet = excel.Worksheets.Add(After: this.worksheet);
        }

        // Method saves workbook at a specified path
        public void SaveAs(string path)
        {
            workbook.SaveAs(path);
        }

        // Method closes Excel file
        public void Close()
        {
            workbook.Close();
        }
    }

}
namespace Projet
{

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Splashcreen());
            System.Windows.Forms.Application.Run(new Séléctionneur());
        }
    }
}
