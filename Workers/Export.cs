using dc.Models;
using System.Collections.Generic;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace dc.Workers
{
    public class Export
    {
        public byte[] WriteExcel(string SheetName, List<Value> values) {
            // Creating an instance 
            // of ExcelPackage 
            ExcelPackage excel = new ExcelPackage();
            // name of the sheet 
            var workSheet = excel.Workbook.Worksheets.Add(SheetName);
            // setting the properties 
            // of the work sheet  
            workSheet.TabColor = System.Drawing.Color.FromName("#1e4691");
            workSheet.DefaultRowHeight = 12;

            // Setting the properties 
            // of the first row 
            workSheet.Row(1).Height = 20;
            workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;

            // Header of the Excel sheet 
            workSheet.Cells[1, 1].Value = "S.No";
            workSheet.Cells[1, 2].Value = "Visitor Id";
            workSheet.Cells[1, 3].Value = "Visitor Type";
            workSheet.Cells[1, 4].Value = "Identity Number";
            workSheet.Cells[1, 5].Value = "FullName";
            workSheet.Cells[1, 6].Value = "ContactNumber";
            workSheet.Cells[1, 7].Value = "WorkEmail";
            workSheet.Cells[1, 8].Value = "Company";
            workSheet.Cells[1, 9].Value = "CheckIn";
            workSheet.Cells[1, 10].Value = "CheckOut";
            workSheet.Cells[1, 11].Value = "Duration";
            workSheet.Cells[1, 12].Value = "Datacenter";
            workSheet.Cells[1, 13].Value = "Purpose";

            // Inserting the article data into excel 
            // sheet by using the for each loop 
            // As we have values to the first row  
            // we will start with second row 
            int recordIndex = 2;

            foreach (var value in values)
            {
                workSheet.Cells[recordIndex, 1].Value = (recordIndex - 1).ToString();
                workSheet.Cells[recordIndex, 2].Value = value.Title;
                workSheet.Cells[recordIndex, 3].Value = value.VisitorType;
                workSheet.Cells[recordIndex, 4].Value = value.IdentityNumber;
                workSheet.Cells[recordIndex, 5].Value = value.FullName;
                workSheet.Cells[recordIndex, 6].Value = value.ContactNumber;
                workSheet.Cells[recordIndex, 7].Value = value.WorkEmail;
                workSheet.Cells[recordIndex, 8].Value = value.Company;
                workSheet.Cells[recordIndex, 9].Value = value.CheckIn.ToString();
                workSheet.Cells[recordIndex, 10].Value = value.CheckOut.ToString();
                workSheet.Cells[recordIndex, 11].Value = value.CheckOut.GetValueOrDefault().Subtract(value.CheckIn.GetValueOrDefault()).ToString();
                workSheet.Cells[recordIndex, 12].Value = value.Datacenter;
                workSheet.Cells[recordIndex, 13].Value = value.PoV;
                recordIndex++;
            }

            // By default, the column width is not  
            // set to auto fit for the content 
            // of the range, so we are using 
            // AutoFit() method here.  
            //workSheet.Column(1).AutoFit();
            //workSheet.Column(2).AutoFit();
            //workSheet.Column(3).AutoFit();

            // file name with .xlsx extension  
            //string p_strPath = "doc\\"+SheetName+".xlsx";

            //if (File.Exists(p_strPath))
                //File.Delete(p_strPath);

            // Create excel file on physical disk  
            //FileStream objFileStrm = File.Create(p_strPath);
            //objFileStrm.Close();

            // Write content to excel file  
            //File.WriteAllBytes(p_strPath, excel.GetAsByteArray());
            //Console.ReadKey();

            return excel.GetAsByteArray();
        }
    }
}
