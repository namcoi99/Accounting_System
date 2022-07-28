using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Accounting_System.Areas.Admin.Pages.UpdateDocumentPage
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Cafe1Context _context;

        public IndexModel(Cafe1Context context)
        {
            _context = context;
        }
        public class TXntcRecord
        {
            public TXntc Xntc { get; set; }
            public TDmKh Kh { get; set; }
            public TDmVthh Vthh { get; set; }
            public TDmTscd Tscd { get; set; }
            public TDmDvt Dvt { get; set; }
            public TDmKho Khonhap { get; set; }
            public TDmKho Khoxuat { get; set; }
            public TDmDvcs Dvcs { get; set; }
            public TDmKhnlh Nlh { get; set; }
        }
        public IList<TXntcRecord> TXntcRecordList { get; set; }
        public TXntc TXntc { get; set; }
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
                .GroupJoin(_context.TDmVthh, xntc => (int)xntc.Xntc.FkVthh, vthh => vthh.PkId,
                (xntc, vthhList) => new
                {
                    Xntc = xntc.Xntc,
                    Kh = xntc.Kh,
                    VthhList = vthhList
                })
                .SelectMany(
                   x => x.VthhList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Kh = x.Kh,
                       Vthh = y
                   })
                .GroupJoin(_context.TDmKho, xntc => xntc.Xntc.FkKhonhap, kho => kho.PkId,
                (xntc, khoList) => new
                {
                    Xntc = xntc.Xntc,
                    Kh = xntc.Kh,
                    Vthh = xntc.Vthh,
                    KhoList = khoList
                })
                .SelectMany(
                   x => x.KhoList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Kh = x.Kh,
                       Vthh = x.Vthh,
                       Khonhap = y
                   })
                .GroupJoin(_context.TDmKho, xntc => xntc.Xntc.FkKhoxuat, kho => kho.PkId,
                (xntc, khoList) => new
                {
                    Xntc = xntc.Xntc,
                    Kh = xntc.Kh,
                    Vthh = xntc.Vthh,
                    Khonhap = xntc.Khonhap,
                    KhoList = khoList
                })
                .SelectMany(
                   x => x.KhoList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Kh = x.Kh,
                       Vthh = x.Vthh,
                       Khonhap = x.Khonhap,
                       Khoxuat = y
                   })
                .GroupJoin(_context.TDmTscd, xntc => xntc.Xntc.FkTscd, tscd => tscd.PkId,
                (xntc, tscdList) => new
                {
                    Xntc = xntc.Xntc,
                    Kh = xntc.Kh,
                    Vthh = xntc.Vthh,
                    Khonhap = xntc.Khonhap,
                    Khoxuat = xntc.Khoxuat,
                    TscdList = tscdList
                })
                .SelectMany(
                   x => x.TscdList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Kh = x.Kh,
                       Vthh = x.Vthh,
                       Khonhap = x.Khonhap,
                       Khoxuat = x.Khoxuat,
                       Tscd = y
                   })
                .GroupJoin(_context.TDmDvt, xntc => xntc.Xntc.FkDvt, dvt => dvt.PkId,
                (xntc, dvtList) => new
                {
                    Xntc = xntc.Xntc,
                    Kh = xntc.Kh,
                    Vthh = xntc.Vthh,
                    Khonhap = xntc.Khonhap,
                    Khoxuat = xntc.Khoxuat,
                    Tscd = xntc.Tscd,
                    DvtList = dvtList
                })
                .SelectMany(
                   x => x.DvtList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Kh = x.Kh,
                       Vthh = x.Vthh,
                       Khonhap = x.Khonhap,
                       Khoxuat = x.Khoxuat,
                       Tscd = x.Tscd,
                       Dvt = y,
                   })
                .GroupJoin(_context.TDmDvcs, xntc => xntc.Xntc.FkDvcs, dvcs => dvcs.PkId,
                (xntc, dvcsList) => new
                {
                    Xntc = xntc.Xntc,
                    Kh = xntc.Kh,
                    Vthh = xntc.Vthh,
                    Khonhap = xntc.Khonhap,
                    Khoxuat = xntc.Khoxuat,
                    Tscd = xntc.Tscd,
                    Dvt = xntc.Dvt,
                    DvcsList = dvcsList
                })
                .SelectMany(
                   x => x.DvcsList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Kh = x.Kh,
                       Vthh = x.Vthh,
                       Khonhap = x.Khonhap,
                       Khoxuat = x.Khoxuat,
                       Tscd = x.Tscd,
                       Dvt = x.Dvt,
                       Dvcs = y
                   })
                .GroupJoin(_context.TDmKhnlh, xntc => xntc.Xntc.FkNguoilh, nlh => nlh.PkId,
                (xntc, nlhList) => new
                {
                    Xntc = xntc.Xntc,
                    Kh = xntc.Kh,
                    Vthh = xntc.Vthh,
                    Khonhap = xntc.Khonhap,
                    Khoxuat = xntc.Khoxuat,
                    Tscd = xntc.Tscd,
                    Dvt = xntc.Dvt,
                    Dvcs = xntc.Dvcs,
                    NlhList = nlhList
                })
                .SelectMany(
                   x => x.NlhList.DefaultIfEmpty(),
                   (x, y) => new TXntcRecord
                   {
                       Xntc = x.Xntc,
                       Kh = x.Kh,
                       Vthh = x.Vthh,
                       Khonhap = x.Khonhap,
                       Khoxuat = x.Khoxuat,
                       Tscd = x.Tscd,
                       Dvt = x.Dvt,
                       Dvcs = x.Dvcs,
                       Nlh = y
                   })
                .ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteChungtuAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TXntc = await _context.TXntc.FindAsync((decimal)id);

            if (TXntc != null)
            {
                _context.TXntc.Remove(TXntc);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
