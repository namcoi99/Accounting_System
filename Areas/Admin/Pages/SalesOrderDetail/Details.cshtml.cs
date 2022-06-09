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
    public class DetailsModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public DetailsModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

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
    }
}
