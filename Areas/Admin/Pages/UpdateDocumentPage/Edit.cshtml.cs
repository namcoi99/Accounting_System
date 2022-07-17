using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.UpdateDocumentPage
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public EditModel(Accounting_System.Models.Cafe1Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TXntc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TXntcExists(TXntc.PkId))
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

        private bool TXntcExists(decimal id)
        {
            return _context.TXntc.Any(e => e.PkId == id);
        }
    }
}
