using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
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
        public IList<string> CurrentColumnNames { get; set; }
        [BindProperty]
        public Dictionary<string, List<object>> TableData { get; set; }
        public int rowsCount { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                // Redirect to home page if the user is not authenticated.
                return RedirectToPage("/login", new { area = "Auth" });
            }
            if (id == null)
            {
                id = Constants.T_SYS_LIST_ID;
            }
            CurrentCatalog = await _context.TSysList
                    .Where(item => item.PkId == id)
                    .FirstOrDefaultAsync();
            CatalogListDetail = await _context.TSysListdetail
                .Where(item => item.FkList == id && item.CVisible == true)
                .ToListAsync();
            CatalogList = await _context.TSysList
                .Where(item => item.CVisible == true)
                .ToListAsync();
            CurrentColumnNames = await _context.TSysListdetail
                .Where(item => item.FkList == id && item.CVisible == true)
                .Select(item => item.CName)
                .ToListAsync();
            GetCurrentTableData();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            foreach (KeyValuePair<string, List<object>> entry in TableData)
            {
                Console.WriteLine(entry.Key);
                Console.WriteLine(Request.Form[entry.Key]);
            }
            return RedirectToPage();
        }

        private void GetCurrentTableData()
        {
            TableData = new Dictionary<string, List<object>>();

            for (int i = 0; i < CurrentColumnNames.Count; i++)
            {
                TableData.Add(CurrentColumnNames[i], new List<object>());
            }
            rowsCount = 0;
            string queryString = "SELECT " + string.Join(",", CurrentColumnNames) + " FROM  dbo." + CurrentCatalog.CTable;
            string connectionString = Constants.CONNECTION_STRING;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        rowsCount++;
                        for (int i = 0; i < CurrentColumnNames.Count; i++)
                        {
                            TableData[CurrentColumnNames[i]].Add(reader[i]);
                        }
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}
