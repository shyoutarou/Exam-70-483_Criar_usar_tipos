using System;
using System.Collections.Generic;
using System.Dynamic;

namespace TiooDinamico_APIs
{
    class Program
    {
        static void Main(string[] args)
        {
            var entities = new List<dynamic> {
                        new{ ColumnA = 1, ColumnB = "Foo"},
                        new { ColumnA= 2, ColumnB= "Bar"}};
            //DisplayInExcel(entities);
            DisplayInExcel_Ex2();

            //dynamic obj = new SampleObject();
            //Console.WriteLine(obj.SomeProperty); // Displays ‘SomeProperty’

            Console.ReadKey();
        }

        static void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;
            excelApp.Workbooks.Add();
            dynamic workSheet = excelApp.ActiveSheet;
            workSheet.Cells[1, "A"] = "Header A";
            workSheet.Cells[1, "B"] = "Header B";
            var row = 1;
            foreach (var entity in entities)
            {
                row++;
                workSheet.Cells[row, "A"] = entity.ColumnA;
                workSheet.Cells[row, "B"] = entity.ColumnB;
            }
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
        }

        static void DisplayInExcel_Ex2()
        {
            // Open the Excel application.
            var excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Add a workbook.
            var workbook = excelApp.Workbooks.Add();
            var sheet = workbook.Worksheets[1];

            // Display 
            excelApp.Visible = true;

            // Display some column headers.
            sheet.Cells[1, 1].Value = "Value";
            sheet.Cells[1, 2].Value = "Value Squared";

            // Display the first 10 squares.
            for (int i = 1; i <= 10; i++)
            {
                sheet.Cells[i + 1, 1].Value = i;
                sheet.Cells[i + 1, 2].Value = (i * i).ToString();
            }

            // Autofit the columns.
            sheet.Columns[1].AutoFit();
            sheet.Columns[2].AutoFit();
        }

        public class SampleObject : DynamicObject
        {
            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                result = binder.Name;
                return true;
            }
        }

        //public ActionResult Index()
        //{
        //    ViewBag.MyDynamicValue = “This property is not statically typed”;
        //    return View();
        //}
    }
}
