using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;

namespace Accounting_System.Areas.Admin.Pages.SalesOrderPage
{
    public class IndexModel : PageModel
    {
        private readonly Cafe1Context _context;

        public IndexModel(Cafe1Context context)
        {
            _context = context;
        }

        public class TDondathangRecord
        {
            public TDondathang Dondathang { get; set; }
            public TDmDvcs Dvcs { get; set; }
            public TDmKh Kh { get; set; }
            public TDmKhnlh Khnlh { get; set; }
            public TDmXe Xe { get; set; }
            public TDmPhongban Pb { get; set; }
            public TDmVuviec Vuviec { get; set; }
        }

        public IList<TDondathangRecord> TDondathangRecordList { get; set; }

        public async Task OnGetAsync()
        {
            TDondathangRecordList = await _context.TDondathang
                .GroupJoin(_context.TDmDvcs, ddh => ddh.FkDvcs, dvcs => dvcs.PkId,
                (dondathang, dvcsList) => new
                {
                    Dondathang = dondathang,
                    DvcsList = dvcsList
                })
                .SelectMany(
                   x => x.DvcsList.DefaultIfEmpty(),
                   (x, y) => new TDondathangRecord { Dondathang = x.Dondathang, Dvcs = y })
                .GroupJoin(_context.TDmKh, ddh => ddh.Dondathang.FkKhachhang, kh => kh.PkId,
                (dondathang, khList) => new
                {
                    Dondathang = dondathang.Dondathang,
                    Dvcs = dondathang.Dvcs,
                    KhList = khList
                })
                .SelectMany(
                   x => x.KhList.DefaultIfEmpty(),
                   (x, y) => new TDondathangRecord
                   {
                       Dondathang = x.Dondathang,
                       Dvcs = x.Dvcs,
                       Kh = y
                   })
                .GroupJoin(_context.TDmKhnlh, ddh => ddh.Dondathang.FkNguoilh, khnlh => khnlh.PkId,
                (dondathang, nlhList) => new
                {
                    Dondathang = dondathang.Dondathang,
                    Dvcs = dondathang.Dvcs,
                    Kh = dondathang.Kh,
                    KhnlhList = nlhList
                })
                .SelectMany(
                   x => x.KhnlhList.DefaultIfEmpty(),
                   (x, y) => new TDondathangRecord
                   {
                       Dondathang = x.Dondathang,
                       Dvcs = x.Dvcs,
                       Kh = x.Kh,
                       Khnlh = y
                   })
                .GroupJoin(_context.TDmXe, ddh => ddh.Dondathang.FkSoxe, xe => (short)xe.PkId,
                (dondathang, xeList) => new
                {
                    Dondathang = dondathang.Dondathang,
                    Dvcs = dondathang.Dvcs,
                    Kh = dondathang.Kh,
                    Khnlh = dondathang.Khnlh,
                    XeList = xeList
                })
                .SelectMany(
                   x => x.XeList.DefaultIfEmpty(),
                   (x, y) => new TDondathangRecord
                   {
                       Dondathang = x.Dondathang,
                       Dvcs = x.Dvcs,
                       Kh = x.Kh,
                       Khnlh = x.Khnlh,
                       Xe = y
                   })
                .GroupJoin(_context.TDmPhongban, ddh => ddh.Dondathang.FkPhongban, pb => pb.PkId,
                (dondathang, pbList) => new
                {
                    Dondathang = dondathang.Dondathang,
                    Dvcs = dondathang.Dvcs,
                    Kh = dondathang.Kh,
                    Khnlh = dondathang.Khnlh,
                    Xe = dondathang.Xe,
                    PbList = pbList
                })
                .SelectMany(
                   x => x.PbList.DefaultIfEmpty(),
                   (x, y) => new TDondathangRecord
                   {
                       Dondathang = x.Dondathang,
                       Dvcs = x.Dvcs,
                       Kh = x.Kh,
                       Khnlh = x.Khnlh,
                       Xe = x.Xe,
                       Pb = y
                   })
                .GroupJoin(_context.TDmVuviec, ddh => ddh.Dondathang.FkVuviec, vuviec => vuviec.PkId,
                (dondathang, vuviecList) => new
                {
                    Dondathang = dondathang.Dondathang,
                    Dvcs = dondathang.Dvcs,
                    Kh = dondathang.Kh,
                    Khnlh = dondathang.Khnlh,
                    Xe = dondathang.Xe,
                    Pb = dondathang.Pb,
                    VuviecList = vuviecList
                })
                .SelectMany(
                   x => x.VuviecList.DefaultIfEmpty(),
                   (x, y) => new TDondathangRecord
                   {
                       Dondathang = x.Dondathang,
                       Dvcs = x.Dvcs,
                       Kh = x.Kh,
                       Khnlh = x.Khnlh,
                       Xe = x.Xe,
                       Pb = x.Pb,
                       Vuviec = y
                   })
                .ToListAsync();
        }
    }
}
