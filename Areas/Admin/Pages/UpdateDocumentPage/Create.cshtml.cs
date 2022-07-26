using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Accounting_System.Areas.Admin.Pages.UpdateDocumentPage
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Cafe1Context _context;

        public CreateModel(Cafe1Context context)
        {
            _context = context;
        }

        public List<SelectListItem> TDmChungtuSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> LoaiXnSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmDvcsSelectList { get; set; } = new List<SelectListItem>();
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

        public async Task<IActionResult> OnGetAsync()
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

            TDmChungtu = _context.TDmChungtu.OrderBy(ct => ct.CMa).ToList();
            TDmDvcs = _context.TDmDvcs.ToList();
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
                TDmKhSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
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
                TDmTaikhoanSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKho)
            {
                TDmKhohangSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
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

            return Page();
        }

        [BindProperty]
        public TXntc TXntc { get; set; } = new TXntc();

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            _context.TXntc.Add(TXntc);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public JsonResult OnPostGetSelectedDocument(int id)
        {
            var result = _context.TDmChungtu.Where(ct => ct.PkId == id).First();
            return new JsonResult(result);
        }
    }
}
