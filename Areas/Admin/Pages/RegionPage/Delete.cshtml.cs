﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;

namespace Accounting_System.Areas.Admin.Pages.RegionPage
{
    public class DeleteModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public DeleteModel(Accounting_System.Models.Cafe1Context context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDondathangdk = await _context.TDondathangdk.FindAsync(id);

            if (TDondathangdk != null)
            {
                _context.TDondathangdk.Remove(TDondathangdk);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
