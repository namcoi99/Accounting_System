﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Accounting_System.Areas.Admin.Pages.ReportPage
{
    [Authorize]
    public class SalesReportModel : PageModel
    {
        private readonly Cafe1Context _context;

        public SalesReportModel(Cafe1Context context)
        {
            _context = context;
        }
        public class TXntcRecord
        {
            public TXntc Xntc { get; set; }
            public TDmVthh Vthh { get; set; }
            public TDmDvt Dvt { get; set; }
            public double Soluong { get; set; }
        }
        public IList<TXntcRecord> PhieuXuatBanHangList { get; set; }
        public double Total { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            PhieuXuatBanHangList = await _context.TXntc
                .Where(m => m.FkChungtu == Constants.PHIEU_XUAT_BAN_HANG_ID && m.CLoaibt == (int)Constants.LoaiBT.BTTT)
                .GroupJoin(_context.TDmVthh, xntc => (int)xntc.FkVthh, vthh => vthh.PkId,
                (xntc, vthhList) => new
                {
                    Xntc = xntc,
                    VthhList = vthhList,
                })
                .SelectMany(
                   x => x.VthhList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Vthh = y,
                   })
                .GroupJoin(_context.TDmDvt, xntc => xntc.Xntc.FkDvt, dvt => dvt.PkId,
                (xntc, dvtList) => new
                {
                    Xntc = xntc.Xntc,
                    Vthh = xntc.Vthh,
                    DvtList = dvtList
                })
                .SelectMany(
                   x => x.DvtList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Vthh = x.Vthh,
                       Dvt = y
                   })
                .ToListAsync();
            Total = PhieuXuatBanHangList.Sum(x => Convert.ToDouble(x.Xntc.CPsno));
            return Page();
        }
    }
}
