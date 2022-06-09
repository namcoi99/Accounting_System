using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;

namespace Accounting_System.Areas.Admin.Pages.SalesOrderDetail
{
    public class DeleteModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public DeleteModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TDondathangct TDondathangct { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDondathangct = await _context.TDondathangct.FirstOrDefaultAsync(m => m.PkId == id);

            if (TDondathangct == null)
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

            TDondathangct = await _context.TDondathangct.FindAsync(id);

            if (TDondathangct != null)
            {
                _context.TDondathangct.Remove(TDondathangct);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
