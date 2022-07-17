using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.UpdateDocumentPage
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
        public TXntc TXntc { get; set; }

        public async Task<IActionResult> OnGetAsync(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TXntc = await _context.TXntc.FirstOrDefaultAsync(m => m.PkId == id);

            if (TXntc == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TXntc = await _context.TXntc.FindAsync(id);

            if (TXntc != null)
            {
                _context.TXntc.Remove(TXntc);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
