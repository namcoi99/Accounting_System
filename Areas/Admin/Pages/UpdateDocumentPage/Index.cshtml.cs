using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.UpdateDocumentPage
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public IndexModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }
        public class TXntcRecord
        {
            public TXntc Xntc { get; set; }
            public TDmKh Kh { get; set; }
            public TDmVthh Vthh { get; set; }
        }
        public IList<TXntcRecord> TXntcRecordList { get; set; }

        public async Task OnGetAsync()
        {
            TXntcRecordList = await _context.TXntc
                .GroupJoin(_context.TDmKh, xntc => xntc.FkKhachhang, kh => kh.PkId,
                (xntc, khList) => new
                {
                    Xntc = xntc,
                    KhList = khList
                })
                .SelectMany(
                   x => x.KhList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Kh = y
                   })
                //.GroupJoin(_context.TDmVthh, xntc => xntc.Xntc.FkVthh, vthh => vthh.PkId,
                //(xntc, vthhList) => new
                //{
                //    Xntc = xntc.Xntc,
                //    Kh = xntc.Kh,
                //    VthhList = vthhList
                //})
                //.SelectMany(
                //   x => x.VthhList.DefaultIfEmpty(),
                //   (x, y) => new TXntcRecord
                //   {
                //       Xntc = x.Xntc,
                //       Kh = x.Kh,
                //       Vthh = y
                //   })
                .ToListAsync();
        }
    }
}
