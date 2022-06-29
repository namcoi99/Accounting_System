using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;

namespace Accounting_System.Areas.Admin.Pages.SalesOrderPage
{
    public class EditModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public EditModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TDondathang TDondathang { get; set; }
        public List<SelectListItem> DvcsSelectList { get; set; } = new List<SelectListItem>();
        //public List<SelectListItem> LoaiBgSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> KhSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TienteSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> NlhSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> VuviecSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PhongbanSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PhanxuongSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> VattuhanghoaSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PtttSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> DkbgSelectList { get; set; } = new List<SelectListItem>();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDondathang = await _context.TDondathang.FirstOrDefaultAsync(m => m.PkId == id);

            if (TDondathang == null)
            {
                return NotFound();
            }
            IList<TDmDvcs> TDvcs;
            IList<TDmKh> TDmKh;
            IList<TDmTiente> TDmTiente;
            IList<TDmKhnlh> TDmKhnlh;
            IList<TDmVuviec> TDmVuviec;
            IList<TDmPhongban> TDmPhongban;
            IList<TDmPhanxuong> TDmPhanxuong;
            IList<TDmVthh> TDmVthh;
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
            TDmVthh = _context.TDmVthh.ToList();
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
            foreach (var item in TDmVthh)
            {
                VattuhanghoaSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
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
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TDondathang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TDondathangExists(TDondathang.PkId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TDondathangExists(int id)
        {
            return _context.TDondathang.Any(e => e.PkId == id);
        }
    }
}
