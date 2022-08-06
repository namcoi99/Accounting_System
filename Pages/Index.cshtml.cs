using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace Accounting_System.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Cafe1Context _context;


        public IndexModel(ILogger<IndexModel> logger, Cafe1Context context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<TXntc> PhieuNhapHangHoaList { get; set; }
        public IList<TXntc> PhieuXuatBanHangList { get; set; }
        public int Sales { get; set; }
        public int SalesPerMonth { get; set; }
        public int Imports { get; set; }
        public int ImportsPerMonth { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            if (!User.Identity.IsAuthenticated)
            {
                // Redirect to home page if the user is not authenticated.
                return RedirectToPage("/login", new { area = "Auth" });
            }
            PhieuNhapHangHoaList = await _context.TXntc.Where(m => m.FkChungtu == Constants.PHIEU_NHAP_HANG_HOA_ID).ToListAsync();
            PhieuXuatBanHangList = await _context.TXntc.Where(m => m.FkChungtu == Constants.PHIEU_XUAT_BAN_HANG_ID).ToListAsync();
            Sales = PhieuXuatBanHangList.Sum(m => Convert.ToInt32(m.CDongia) * Convert.ToInt32(m.CSoluong));
            Imports = PhieuNhapHangHoaList.Sum(m => Convert.ToInt32(m.CDongia) * Convert.ToInt32(m.CSoluong));
            SalesPerMonth = PhieuXuatBanHangList.Where(m => m.CNgaylap.Value.Month == DateTime.Now.Month).Sum(m => Convert.ToInt32(m.CDongia) * Convert.ToInt32(m.CSoluong));
            ImportsPerMonth = PhieuNhapHangHoaList.Where(m => m.CNgaylap.Value.Month == DateTime.Now.Month).Sum(m => Convert.ToInt32(m.CDongia) * Convert.ToInt32(m.CSoluong));
            return Page();
        }
    }
}
