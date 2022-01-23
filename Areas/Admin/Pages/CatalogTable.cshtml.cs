using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Accounting_System.Areas.Admin.Pages
{
    public class CatalogTableModel : PageModel
    {
        private readonly ILogger<CatalogTableModel> _logger;
        private readonly Cafe1Context _context;


        public CatalogTableModel(ILogger<CatalogTableModel> logger, Cafe1Context context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<TSysList> CatalogList { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            if (!User.Identity.IsAuthenticated)
            {
                // Redirect to home page if the user is not authenticated.
                return RedirectToPage("/login", new { area = "Auth" });
            }
            CatalogList = await _context.TSysList.ToListAsync();
            return Page();
        }
        public List<TSysList> GetCatalogChildren(string parent)
        {
            var children = _context.TSysList
                .Where(child => child.CParent == parent)
                .ToList();
            return children;
        }
    }
}
