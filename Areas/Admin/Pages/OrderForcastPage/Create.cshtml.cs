using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Accounting_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System;

namespace Accounting_System.Areas.Admin.Pages.OrderForcastPage
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Cafe1Context _context;

        public CreateModel(Cafe1Context context)
        {
            _context = context;
        }
        public List<SelectListItem> DvcsSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PhongbanSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> KhachhangSelectList { get; set; } = new List<SelectListItem>();

        [BindProperty]
        public string UserId { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
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

            return Page();
        }

        [BindProperty]
        public TDubao TDubao { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            _context.TDubao.Add(TDubao);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Details", new { id = TDubao.PkId });
        }
    }
}
