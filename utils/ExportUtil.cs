using CashierApp3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;


namespace CashierApp3.utils
{
    internal static class ExportUtil
    {
        public static void ExportToExcel(List<SaleDto> list)
        {
            // Create a new Excel application
            var excelApp = new Excel.Application();
            excelApp.Visible = false; // Set to true if you want to see the process

            // Create a new workbook
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel._Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            // Add headers
            worksheet.Cells[1, 1] = "Product";
            worksheet.Cells[1, 2] = "Count";
            worksheet.Cells[1, 3] = "Datetime";

            // Add data
            for (int i = 0; i < list.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = list[i].Product;
                worksheet.Cells[i + 2, 2] = list[i].Count;
                worksheet.Cells[i + 2, 3] = list[i].Datetime.ToString("yyyy-MM-dd HH:mm:ss");
            }

            // Save the workbook
            string filePath = "FilteredData.xlsx";
            workbook.SaveAs(filePath);

            // Cleanup
            workbook.Close();
            excelApp.Quit();

            // Release COM objects to fully kill Excel process from running in the background
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

            worksheet = null;
            workbook = null;
            excelApp = null;

            GC.Collect(); // Manually invoke garbage collection
            GC.WaitForPendingFinalizers();
        }






    }
}
