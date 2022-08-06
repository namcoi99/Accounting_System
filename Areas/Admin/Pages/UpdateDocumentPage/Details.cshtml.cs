using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Accounting_System.Areas.Admin.Pages.UpdateDocumentPage
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly Cafe1Context _context;
        private readonly INotyfService _notyf;

        public DetailsModel(Cafe1Context context, INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
        }

        public class TXntcRecord
        {
            public TXntc Xntc { get; set; }
            public TDmVthh Vthh { get; set; }
        }

        public List<SelectListItem> TDmChungtuSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> LoaiXnSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmDvcsSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> VattuhanghoaSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmKhSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmLoaitienSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmNguoilhSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmPhongbanSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmTaikhoanSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmKhohangSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmKehangSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmVuviecSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmPtttSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmDtcpSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmPhanxuongSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmKmpSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDondathangSelectList { get; set; } = new List<SelectListItem>();
        [BindProperty]
        public byte SelectedDvcs { get; set; }
        public short FkDvcs { get; set; }
        public int FkChungtu { get; set; }
        [BindProperty]
        public TXntcorder TXntcorder { get; set; }
        [BindProperty]
        public TXntc TXntc { get; set; } = new TXntc();
        [BindProperty]
        public TXntc TXntcItem { get; set; } = new TXntc();
        public IList<TXntcRecord> TXntcList { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("./Index");
            }
            TXntcorder = await _context.TXntcorder.FirstOrDefaultAsync(m => m.PkId == id);
            if (TXntcorder == null)
            {
                return NotFound();
            }
            await InitializeModel();
            TXntcList = await _context.TXntc
                .Where(item => item.FkOrder == id && item.CLoaibt == (byte)Constants.LoaiBT.BTTT)
                .Join(_context.TDmVthh, xntc => (int)xntc.FkVthh, vthh => vthh.PkId,
                (xntc, vthh) => new TXntcRecord
                {
                    Xntc = xntc,
                    Vthh = vthh
                }).ToListAsync();
            if (TXntcList.FirstOrDefault() != null)
            {
                TXntc = TXntcList.FirstOrDefault().Xntc;
                FkDvcs = TXntc.FkDvcs;
                FkChungtu = (int)TXntc.FkChungtu;
            }
            else
            {
                TXntc = new TXntc();
                TXntc.FkChungtu = TXntcorder.FkOrder;
                TXntc.FkDvcs = (byte)TXntcorder.FkDvcs;
                TXntc.CSophieu = TXntcorder.CSophieu;
                TXntc.FkOrder = (int)id;
            }
            return Page();
        }

        private async Task InitializeModel()
        {
            IList<TDmChungtu> TDmChungtu;
            IList<TDmDvcs> TDmDvcs;
            IList<TDmKh> TDmKh;
            IList<TDmTiente> TDmTiente;
            IList<TDmKhnlh> TDmKhnlh;
            IList<TDmPhongban> TDmPhongban;
            IList<TDmTaikhoan> TDmTaikhoan;
            IList<TDmKho> TDmKho;
            IList<TDmKehang> TDmKehang;
            IList<TDmPttt> TDmPttt;
            IList<TDmDtcp> TDmDtcp;
            IList<TDmPhanxuong> TDmPhanxuong;
            IList<TDmKmp> TDmKmp;
            IList<TDondathang> TDondathang;
            IList<TDmVthh> TDmVthh;

            TDmChungtu = _context.TDmChungtu.OrderBy(ct => ct.CMa).ToList();
            TDmDvcs = _context.TDmDvcs.ToList();
            TDmVthh = _context.TDmVthh.ToList();
            TDmKh = _context.TDmKh.ToList();
            TDmTiente = _context.TDmTiente.ToList();
            TDmKhnlh = _context.TDmKhnlh.ToList();
            TDmPhongban = _context.TDmPhongban.ToList();
            TDmTaikhoan = _context.TDmTaikhoan.ToList();
            TDmKho = _context.TDmKho.ToList();
            TDmKehang = _context.TDmKehang.ToList();
            TDmPttt = _context.TDmPttt.ToList();
            TDmDtcp = _context.TDmDtcp.ToList();
            TDmPhanxuong = _context.TDmPhanxuong.ToList();
            TDmKmp = _context.TDmKmp.ToList();
            TDondathang = _context.TDondathang.ToList();
            await Task.WhenAll();

            foreach (var item in TDmChungtu)
            {
                TDmChungtuSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CTen });
            }
            foreach (var item in TDmDvcs)
            {
                TDmDvcsSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKh)
            {
                TDmKhSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CTen });
            }
            foreach (var item in TDmTiente)
            {
                TDmLoaitienSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKhnlh)
            {
                TDmNguoilhSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CTen });
            }
            foreach (var item in TDmPhongban)
            {
                TDmPhongbanSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmTaikhoan)
            {
                TDmTaikhoanSelectList.Add(new SelectListItem { Value = item.CMa.ToString(), Text = item.CMa + " - " + item.CTen });
            }
            foreach (var item in TDmKho)
            {
                TDmKhohangSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CMota });
            }
            foreach (var item in TDmKehang)
            {
                TDmKehangSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmPttt)
            {
                TDmPtttSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CMota });
            }
            foreach (var item in TDmDtcp)
            {
                TDmDtcpSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmPhanxuong)
            {
                TDmPhanxuongSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKmp)
            {
                TDmKmpSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDondathang)
            {
                TDondathangSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CSophieu });
            }
            foreach (var item in TDmVthh)
            {
                VattuhanghoaSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var included = new[] { "CNgaylap", "CDiengiai", "CSophieu", "FkKhachhang", "CKhdiachi", "FkNguoilh", "CNguoilh", "FkTkno", "FkTkco", "FkKhoxuat", "FkKhonhap", "CNgayct", "CMahoadon", "CKyhieumau", "CVat", "FkPhongban", "FkPhanxuong", "FkLoaitien", "CTigia", "FkPttt", "CSotknh" };
            IList<TXntc> tXntcList;
            tXntcList = await _context.TXntc.Where(m => m.FkOrder == TXntc.FkOrder).ToListAsync();
            foreach (TXntc xntc in tXntcList)
            {
                var entry = _context.Entry(xntc);
                foreach (var name in included)
                {
                    entry.Property(name).IsModified = true;
                    entry.Property(name).CurrentValue = _context.Entry(TXntc).Property(name).CurrentValue;
                }
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TXntcExists(xntc.PkId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            _notyf.Success("Cập nhật thông tin thành công.");
            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostCreateVthhAsync()
        {
            var included = new[] { "FkOrder", "CNgaylap", "CDiengiai", "CSophieu", "FkKhachhang", "CKhdiachi", "FkNguoilh", "CNguoilh", "FkTkno", "FkTkco", "FkKhoxuat", "FkKhonhap", "CNgayct", "CMahoadon", "CKyhieumau", "CVat", "FkPhongban", "FkPhanxuong", "FkLoaitien", "CTigia", "FkPttt", "CSotknh" };
            foreach (var name in included)
            {
                TXntcItem.GetType().GetProperty(name).SetValue(new TXntc(), _context.Entry(TXntc).Property(name).CurrentValue, null);
            }
            _context.TXntc.Add(TXntcItem);
            await _context.SaveChangesAsync();
            _notyf.Success("Tạo mới thành công.");
            return RedirectToPage("./Details", new { id = TXntcItem.FkOrder });
        }
        private bool TXntcExists(decimal id)
        {
            return _context.TXntc.Any(e => e.PkId == id);
        }

        public JsonResult OnPostGetSelectedDocument(int id)
        {
            var result = _context.TDmChungtu.Where(ct => ct.PkId == id).First();
            return new JsonResult(result);
        }
        public JsonResult OnPostGetSelectedCustomer(int id)
        {
            var result = _context.TDmKh.Where(kh => kh.PkId == id).First();
            return new JsonResult(result);
        }
    }
}
