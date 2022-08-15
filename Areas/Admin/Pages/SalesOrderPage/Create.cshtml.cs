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

namespace Accounting_System.Areas.Admin.Pages.SalesOrderPage
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
        public List<SelectListItem> DvcsSelectList { get; set; } = new List<SelectListItem>();
        //public List<SelectListItem> LoaiBgSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> KhSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TienteSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> NlhSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> VuviecSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PhongbanSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PhanxuongSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PtttSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> DkbgSelectList { get; set; } = new List<SelectListItem>();

        public async Task<IActionResult> OnGetAsync()
        {
            IList<TDmDvcs> TDvcs;
            IList<TDmKh> TDmKh;
            IList<TDmTiente> TDmTiente;
            IList<TDmKhnlh> TDmKhnlh;
            IList<TDmVuviec> TDmVuviec;
            IList<TDmPhongban> TDmPhongban;
            IList<TDmPhanxuong> TDmPhanxuong;
            //IList<TDmLoaibg> TDmLoaibg;
            IList<TDmPttt> TDmPttt;
            IList<TDmDkbg> TDmDkbg;
            TDvcs = _context.TDmDvcs.ToList();
            TDmKh = _context.TDmKh.ToList();
            TDmTiente = _context.TDmTiente.ToList();
            TDmKhnlh = _context.TDmKhnlh.ToList();
            TDmVuviec = _context.TDmVuviec.ToList();
            TDmPhongban = _context.TDmPhongban.ToList();
            TDmPhanxuong = _context.TDmPhanxuong.ToList();
            //TDmLoaibg = _context.TDmLoaibg.ToList();
            TDmPttt = _context.TDmPttt.ToList();
            TDmDkbg = _context.TDmDkbg.ToList();

            await Task.WhenAll();
            foreach (var item in TDvcs)
            {
                DvcsSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKh)
            {
                KhSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmTiente)
            {
                TienteSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKhnlh)
            {
                NlhSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CTen });
            }
            foreach (var item in TDmVuviec)
            {
                VuviecSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmPhongban)
            {
                PhongbanSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmPhanxuong)
            {
                PhanxuongSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            //foreach (var item in TDmLoaibg)
            //{
            //    LoaiBgSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMota });
            //}
            foreach (var item in TDmPttt)
            {
                PtttSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMota });
            }
            foreach (var item in TDmDkbg)
            {
                DkbgSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMota });
            }
            TDondathang.CNgaylap = System.DateTime.Now;
            TDmTigia tigia = await _context.TDmTigia.Where(m => m.CNgay.Year == System.DateTime.Now.Year).FirstOrDefaultAsync();
            TDondathang.CTigia = tigia != null ? tigia.CTigia : 0;
            return Page();
        }

        [BindProperty]
        public TDondathang TDondathang { get; set; } = new TDondathang();

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostCreateSalesOrderAsync()
        {
            var dondathang = await _context.TDondathang.Where(m => string.Equals(m.CSophieu, TDondathang.CSophieu)).FirstOrDefaultAsync();
            if (dondathang != null)
            {
                _notyf.Error("Đơn đặt hàng với số phiếu " + TDondathang.CSophieu + " đã tồn tại.");
                return RedirectToPage("./Create");
            }
            _context.TDondathang.Add(TDondathang);
            await _context.SaveChangesAsync();
            _notyf.Success("Tạo mới đơn đặt hàng thành công.");
            return RedirectToPage("./Details", new { id = TDondathang.PkId });
        }
        public JsonResult OnPostGetSelectedCustomer(int id)
        {
            var result = _context.TDmKh.Where(kh => kh.PkId == id).FirstOrDefault();
            return new JsonResult(result);
        }

        public JsonResult OnPostGetLoaiBg(int id)
        {
            var result = _context.TDmLoaibg.Where(m => m.CMa == id).FirstOrDefault();
            return new JsonResult(result);
        }
    }
}
