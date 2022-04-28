using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;

namespace Accounting_System.Areas.Admin.Pages.CountryPage
{
    public class DetailsModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public DetailsModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        public TDmQuocgia TDmQuocgia { get; set; }

        public async Task<IActionResult> OnGetAsync(byte? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDmQuocgia = await _context.TDmQuocgia.FirstOrDefaultAsync(m => m.PkId == id);

            if (TDmQuocgia == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
