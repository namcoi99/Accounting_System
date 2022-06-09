using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.Data.SqlClient;

namespace Accounting_System.Areas.Admin.Pages.SalesOrderPage
{
    public class IndexModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public IndexModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }

        public IList<TDondathang> TDondathang { get;set; }

        public async Task OnGetAsync()
        {
            TDondathang = await _context.TDondathang.ToListAsync();
        }
    }
}
