﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;

namespace Accounting_System.Areas.Admin.Pages.RegionPage
{
    public class EditModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public EditModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public TDondathangdk TDondathangdk { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDondathangdk = await _context.TDondathangdk
                .Include(t => t.FkDondathangNavigation).FirstOrDefaultAsync(m => m.PkId == id);

            if (TDondathangdk == null)
            {
                return NotFound();
            }
           ViewData["FkDondathang"] = new SelectList(_context.TDondathang, "PkId", "CSophieu");
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

            _context.Attach(TDondathangdk).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TDondathangdkExists(TDondathangdk.PkId))
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

        private bool TDondathangdkExists(int id)
        {
            return _context.TDondathangdk.Any(e => e.PkId == id);
        }
    }
}
