using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace Accounting_System.Areas.Admin.Pages.UpdateDocumentPage
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Cafe1Context _context;
        private readonly INotyfService _notyf;
        public CreateModel(Cafe1Context context, INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
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
        public List<SelectListItem> TDmDvtSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmLdhhSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmTscdSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmNguonvonSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmLdtgSelectList { get; set; } = new List<SelectListItem>();
        [BindProperty]
        public byte SelectedDvcs { get; set; }
        public short FkDvcs { get; set; }
        public int FkChungtu { get; set; }
        [BindProperty]
        public TXntc TXntc { get; set; } = new TXntc();
        public async Task<IActionResult> OnGetAsync()
        {
            await InitializeModel();
            TXntc.CNgaylap = System.DateTime.Now;
            TDmTigia tigia = await _context.TDmTigia.Where(m => m.CNgay.Year == System.DateTime.Now.Year).FirstOrDefaultAsync();
            TXntc.CTigia = tigia != null ? (double)tigia.CTigia : 0;
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
            IList<TDmDvt> TDmDvt;
            IList<TDmLdhh> TDmLdhh;
            IList<TDmTscd> TDmTscd;
            IList<TDmNguonvon> TDmNguonvon;
            IList<TDmLdtg> TDmLdtg;

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
            TDmDvt = _context.TDmDvt.ToList();
            TDmLdhh = _context.TDmLdhh.ToList();
            TDmTscd = _context.TDmTscd.ToList();
            TDmNguonvon = _context.TDmNguonvon.ToList();
            TDmLdtg = _context.TDmLdtg.ToList();
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
                VattuhanghoaSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CTen });
            }
            foreach (var item in TDmDvt)
            {
                TDmDvtSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CMota });
            }
            foreach (var item in TDmLdhh)
            {
                TDmLdhhSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CMota });
            }
            foreach (var item in TDmTscd)
            {
                TDmTscdSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CTen });
            }
            foreach (var item in TDmNguonvon)
            {
                TDmNguonvonSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CTen });
            }
            foreach (var item in TDmLdtg)
            {
                TDmLdtgSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CMota });
            }
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var xntc = await _context.TXntcorder.Where(m => string.Equals(m.CSophieu, TXntc.CSophieu)).FirstOrDefaultAsync();
            if(xntc != null)
            {
                _notyf.Error("Chứng từ với số phiếu " + TXntc.CSophieu + " đã tồn tại.");
                return RedirectToPage("./Create");
            }
            TXntcorder order = new TXntcorder();
            order.FkDvcs = TXntc.FkDvcs;
            order.CSophieu = TXntc.CSophieu;
            _context.TXntcorder.Add(order);
            await _context.SaveChangesAsync();
            TXntc.FkOrder = order.PkId;
            _context.TXntc.Add(TXntc);
            await _context.SaveChangesAsync();
            _notyf.Success("Thêm mới dữ liệu thành công.");
            return RedirectToPage("./Details", new { id = TXntc.FkOrder });
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
        public JsonResult OnPostGetSelectedProduct(int id)
        {
            var result = _context.TDmVthh.Where(vthh => vthh.PkId == id).First();
            return new JsonResult(result);
        }
    }
}
