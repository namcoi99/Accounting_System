using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.UpdateDocumentPage
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly Cafe1Context _context;

        public DetailsModel(Cafe1Context context)
        {
            _context = context;
        }

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
    }
}
