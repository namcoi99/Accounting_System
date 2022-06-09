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
    public class IndexModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public IndexModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        public IList<TDondathangct> TDondathangct { get;set; }

        public async Task OnGetAsync()
        {
            TDondathangct = await _context.TDondathangct.ToListAsync();
        }
    }
}
