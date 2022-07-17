using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounting_System.Helpers;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace Accounting_System.Areas.Admin.Pages.ReportPage
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public IndexModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await ExportData();   
            return RedirectToPage("./Index");
        }
        private async Task ExportData()
        {
            var file = Utils.GetCleanFileInfo(@"C:\Users\WIN10\Downloads\Report\report.xlsx");
            using (var package = new ExcelPackage(file))
            {
                int startRow = 2;
                var sheet = package.Workbook.Worksheets.Add("Báo cáo");
                sheet.Cells["A1"].Value = "Mã VTHH";
                sheet.Cells["B1"].Value = "Tên VTHH";
                sheet.Cells["C1"].Value = "ĐVT";
                IList<TDmVthh> TDmVthh = _context.TDmVthh.ToList();
                IList<TDmDvt> TDmDvt = _context.TDmDvt.ToList();
                await Task.WhenAll();
                foreach (TDmVthh vthh in TDmVthh)
                {
                    sheet.Cells[startRow, 1].Value = vthh.CMa;
                    sheet.Cells[startRow, 2].Value = vthh.CTen;
                    sheet.Cells[startRow, 3].Value = TDmDvt.Where(dvt => dvt.PkId == vthh.FkDvtonkho).FirstOrDefault().CMota;
                    startRow++;
                }
                package.Save();
            }
        }
    }
}
