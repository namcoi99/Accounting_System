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
        public IList<TSysListdetail> CatalogListDetail { get; set; }
        public TSysList CurrentCatalog { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                // Redirect to home page if the user is not authenticated.
                return RedirectToPage("/login", new { area = "Auth" });
            }
            if(id == null)
            {
                id = 21;
            }
            CurrentCatalog = _context.TSysList
                    .Where(item => item.PkId == id)
                    .FirstOrDefault();
            CatalogListDetail = _context.TSysListdetail
                .Where(item => item.FkList == id)
                .ToList();
            CatalogList = await _context.TSysList.ToListAsync();
            return Page();
        }
    }
}
