using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.CustomerPage
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public CreateModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TDmKh TDmKh { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TDmKh.Add(TDmKh);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
