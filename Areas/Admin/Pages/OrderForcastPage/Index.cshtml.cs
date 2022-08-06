using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.OrderForcastPage
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public IndexModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }
        public class TDubaoRecord
        {
            public TDubao Dubao { get; set; }
            public TDmKh Kh { get; set; }
            public TDmDvcs Dvcs { get; set; }
            public string Nguoilap { get; set; }
            public TDmPhongban Pb { get; set; }
        }
        public IList<TDubaoRecord> TDubao { get;set; }

        public async Task OnGetAsync()
        {
            TDubao = await _context.TDubao
                .GroupJoin(_context.TDmKh, db => db.FkKhachhang, kh => kh.PkId,
                (db, khList) => new  {
                    Dubao = db,
                    KhList = khList
                })
                .SelectMany(
                   x => x.KhList.DefaultIfEmpty(),
                   (x, y) => new TDubaoRecord
                   {
                       Dubao = x.Dubao,
                       Kh = y,
                   })
                .GroupJoin(_context.TDmDvcs, db => db.Dubao.FkDvcs, dvcs => dvcs.PkId,
                (dubao, dvcsList) => new
                {
                    Dubao = dubao.Dubao,
                    Kh = dubao.Kh,
                    DvcsList = dvcsList
                })
                .SelectMany(
                   x => x.DvcsList.DefaultIfEmpty(),
                   (x, y) => new TDubaoRecord
                   {
                       Dubao = x.Dubao,
                       Kh = x.Kh,
                       Dvcs = y
                   })
                .GroupJoin(_context.TSysAccount, db => db.Dubao.FkUser, acc => acc.PkId,
                (dubao, accountList) => new
                {
                    Dubao = dubao.Dubao,
                    Kh = dubao.Kh,
                    Dvcs = dubao.Dvcs,
                    AccountList = accountList
                })
                .SelectMany(
                   x => x.AccountList.DefaultIfEmpty(),
                   (x, y) => new TDubaoRecord
                   {
                       Dubao = x.Dubao,
                       Kh = x.Kh,
                       Dvcs = x.Dvcs,
                       Nguoilap = y.CMa
                   })
                .GroupJoin(_context.TDmPhongban, db => db.Dubao.FkPhongban, pb => pb.PkId,
                (dubao, pbList) => new
                {
                    Dubao = dubao.Dubao,
                    Kh = dubao.Kh,
                    Dvcs = dubao.Dvcs,
                    Nguoilap = dubao.Nguoilap,
                    PhongbanList = pbList
                })
                .SelectMany(
                   x => x.PhongbanList.DefaultIfEmpty(),
                   (x, y) => new TDubaoRecord
                   {
                       Dubao = x.Dubao,
                       Kh = x.Kh,
                       Dvcs = x.Dvcs,
                       Nguoilap = x.Nguoilap,
                       Pb = y
                   })
                .ToListAsync();
        }
    }
}
