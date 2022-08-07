using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounting_System.Helpers;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Accounting_System.Areas.Admin.Pages.ReportPage
{
    [Authorize]
    public class ReportViewModel : PageModel
    {
        private readonly Cafe1Context _context;

        public ReportViewModel(Cafe1Context context)
        {
            _context = context;
        }
        public string reportPath = "sales-order-detail.rdl";
        public string serviceUrl = "/api/ReportViewer";
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
