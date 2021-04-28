using OfficeOpenXml;

namespace ExcelTable
{
    public class CreateExcelTable
    {
        public byte[] Generate(ExcelReport report)
        {
            var pack = new ExcelPackage();
            var sheet = pack.Workbook.Worksheets.Add("Load Report");
            sheet.Cells["B2"].Value = "Load:";
            sheet.Cells[2, 3].Value = report.Load.Name;
            sheet.Cells["B3"].Value = "Other:";
            sheet.Cells["C3"].Value = $"{report.Load.Height}";
            pack.Workbook.Protection.LockStructure = true;
            pack.Workbook.Protection.SetPassword("password");
            return pack.GetAsByteArray();
        }
    }
}