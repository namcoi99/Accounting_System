using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;

namespace Accounting_System.Areas.Admin.Pages.SalesOrderPage
{
    public class DeleteModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public DeleteModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TDondathang TDondathang { get; set; }

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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDondathang = await _context.TDondathang.FindAsync(id);

            if (TDondathang != null)
            {
                _context.TDondathang.Remove(TDondathang);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
