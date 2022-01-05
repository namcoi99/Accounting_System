using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting_System.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Cafe1Context _context;


        public IndexModel(ILogger<IndexModel> logger, Cafe1Context context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<TSysCommand> CommandList { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            if (!User.Identity.IsAuthenticated)
            {
                // Redirect to home page if the user is authenticated.
                return RedirectToPage("/login", new { area = "Auth" });
            }
            CommandList = await _context.TSysCommand.ToListAsync();
            return Page();
        }
    }
}
