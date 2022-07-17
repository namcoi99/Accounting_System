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
    public class DeleteModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public DeleteModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TDubao TDubao { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDubao = await _context.TDubao.FirstOrDefaultAsync(m => m.PkId == id);

            if (TDubao == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDubao = await _context.TDubao.FindAsync(id);

            if (TDubao != null)
            {
                _context.TDubao.Remove(TDubao);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
