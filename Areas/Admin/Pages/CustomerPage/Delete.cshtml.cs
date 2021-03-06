using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.CustomerPage
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly Cafe1Context _context;

        public DeleteModel(Cafe1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TDmKh TDmKh { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDmKh = await _context.TDmKh.FirstOrDefaultAsync(m => m.PkId == id);

            if (TDmKh == null)
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

            TDmKh = await _context.TDmKh.FindAsync(id);

            if (TDmKh != null)
            {
                _context.TDmKh.Remove(TDmKh);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
