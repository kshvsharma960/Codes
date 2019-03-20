using System.Web;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSExcel = Microsoft.Office.Interop.Excel;
namespace ExcelGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            dt = ExportExcel.GetTable();
            Console.WriteLine("Generating.....");
            string path = ExportExcel.ExportDataTableToExcel(dt, @"Test.xlsx");
            Console.WriteLine("Generated...."+path);
            Console.ReadLine();
        }
    }

    //Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
    //            excelWorkSheet.Name = table.TableName;

    //            for (int i = 1; i < table.Columns.Count + 1; i++)
    //            {
    //                excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
    //            }

    //            for (int j = 0; j < table.Rows.Count; j++)
    //            {
    //                for (int k = 0; k < table.Columns.Count; k++)
    //                {
    //                    excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
    //                }
    //            }
    //        }

    //        excelWorkBook.Save();
    //        excelWorkBook.Close();
    public class ExportExcel {
        public static string ExportDataTableToExcel(DataTable  dt,string fn)
        {
            string str = "";
            str = (string)dt.Rows[0][1];
            MSExcel.Application excel = new MSExcel.Application();
            excel.DisplayAlerts = false;
            string submittedFilePath = @"C:\Users\510832\Documents\Files\" + fn;
            MSExcel.Workbook excelbook = excel.Workbooks.Add();
            
            MSExcel.Worksheet excelsheet = excelbook.Sheets.Add();
            excelsheet.Name = fn;


            int n = 0;
            for (int i = 1; i <= dt.Columns.Count ; i++) {
                excelsheet.Cells[1, i] = dt.Columns[i-1].ColumnName.ToString();
                
            }
            n = dt.Columns.Count;
            MSExcel.Range range1 = excel.ActiveCell.Worksheet.Cells[1, n] as MSExcel.Range;
            range1.AutoFormat(MSExcel.XlRangeAutoFormat.xlRangeAutoFormatList3);
            
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {                
                for (int j = 0; j <= dt.Columns.Count - 1; j++)
                    excelsheet.Cells[i+2, j+1] = dt.Rows[i][j].ToString();
            }
            MSExcel.Range range2 = excel.ActiveCell.Worksheet.Cells[dt.Rows.Count, n] as MSExcel.Range;
            range2.AutoFormat(MSExcel.XlRangeAutoFormat.xlRangeAutoFormatList3);
            
            excelbook.SaveAs(submittedFilePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, MSExcel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);
            excelbook.Close();
            excel.Quit();

            return submittedFilePath;
        }
        public static DataTable GetTable()
        {
            //  
            // Here we create a DataTable with four columns.  
            //  
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Sex", typeof(string));
            table.Columns.Add("CreatedDate", typeof(string));
            table.Columns.Add("City", typeof(string));
            //  
            // Here we add five DataRows.  
            //  
            table.Rows.Add(25, "Keshav Sharma", "M", DateTime.Now, "Noida");
            table.Rows.Add(50, "Nikhil Vats", "M", DateTime.Now, "Noida");
            table.Rows.Add(10, "Heena Sharma", "F", DateTime.Now, "Delhi");
            table.Rows.Add(21, "Nancy Sharma", "F", DateTime.Now.ToString(), "Delhi");
            table.Rows.Add(100, "Avinash", "M", DateTime.Now, "Delhi");
            table.Rows.Add(25, "Devesh gupta", "M", DateTime.Now, "Delhi");
            table.Rows.Add(50, "Nikhil gupta", "M", DateTime.Now, "Noida");
            table.Rows.Add(10, "HS gupta", "F", DateTime.Now, "Delhi");
            table.Rows.Add(21, "VS gupta", "F", DateTime.Now, "Delhi");
            table.Rows.Add(100, "RJ gupta", "M", DateTime.Now, "Delhi");
            return table;
        }   

    }

}
