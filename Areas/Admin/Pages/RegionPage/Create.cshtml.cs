﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Accounting_System.Models;

namespace Accounting_System.Areas.Admin.Pages.RegionPage
{
    public class CreateModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public CreateModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FkDondathang"] = new SelectList(_context.TDondathang, "PkId", "CSophieu");
            return Page();
        }

        [BindProperty]
        public TDondathangdk TDondathangdk { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TDondathangdk.Add(TDondathangdk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
