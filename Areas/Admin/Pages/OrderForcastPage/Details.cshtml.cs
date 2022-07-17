using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.OrderForcastPage
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public DetailsModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }
        public List<SelectListItem> DvcsSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PhongbanSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> KhachhangSelectList { get; set; } = new List<SelectListItem>();
        public TDubao TDubao { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IList<TDmDvcs> TDvcs;
            IList<TDmPhongban> TDmPhongban;
            IList<TDmKh> TDmKh;
            TDvcs = _context.TDmDvcs.ToList();
            TDmPhongban = _context.TDmPhongban.ToList();
            TDmKh = _context.TDmKh.ToList();
            await Task.WhenAll();
            foreach (var item in TDvcs)
            {
                DvcsSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmPhongban)
            {
                PhongbanSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKh)
            {
                KhachhangSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CTen });
            }

            TDubao = await _context.TDubao.FirstOrDefaultAsync(m => m.PkId == id);

            if (TDubao == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TDubao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TDubaoExists(TDubao.PkId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Details", new { id = TDubao.PkId });
        }

        private bool TDubaoExists(int id)
        {
            return _context.TDubao.Any(e => e.PkId == id);
        }
    }
}
