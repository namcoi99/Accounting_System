using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Accounting_System.Areas.Admin.Pages.CatalogPage
{
    public class IndexModel : PageModel
    {
        private readonly Cafe1Context _context;
        private readonly IConfiguration _config;
        public IndexModel(Cafe1Context context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        public int? CurrentCatalogId { get; set; }
        public IList<TSysList> CatalogList { get; set; }
        public IList<TSysListdetail> CatalogListDetail { get; set; }
        [BindProperty]
        public TSysList CurrentCatalog { get; set; }
        public IList<string> CurrentColumnNames { get; set; }
        [BindProperty]
        public Dictionary<string, List<object>> TableData { get; set; }
        public int RowsCount { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                // Redirect to home page if the user is not authenticated.
                return RedirectToPage("/login", new { area = "Auth" });
            }
            CatalogList = await _context.TSysList
                .Where(item => item.CVisible == true)
                .ToListAsync();
            CurrentCatalogId = id;
            if (CurrentCatalogId != null)
            {
                CurrentCatalog = await _context.TSysList
                        .Where(item => item.PkId == CurrentCatalogId)
                        .FirstOrDefaultAsync();
                CatalogListDetail = await _context.TSysListdetail
                    .Where(item => item.FkList == CurrentCatalogId && item.CVisible == true)
                    .ToListAsync();
                CurrentColumnNames = await _context.TSysListdetail
                    .Where(item => item.FkList == CurrentCatalogId && item.CVisible == true)
                    .Select(item => item.CName)
                    .ToListAsync();
                GetCurrentTableData();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Dictionary<string, List<object>> tempTableData = TableData;
            tempTableData.Remove("__RequestVerificationToken");
            tempTableData.Remove("C_TABLE");
            string keyString = "";
            string keyValue = "";
            string queryString = "UPDATE " + Request.Form["C_TABLE"] + " SET ";
            List<string> queryArray = new List<string>();
            foreach (KeyValuePair<string, List<object>> entry in tempTableData)
            {
                if (string.Equals(entry.Key, "PK_ID") | string.Equals(entry.Key, "C_MA"))
                {
                    keyString = entry.Key;
                    keyValue = Request.Form[entry.Key];
                }
                else
                {
                    queryArray.Add(entry.Key + " = N'" + Request.Form[entry.Key] + "'");
                }
            }
            queryString += string.Join(",", queryArray);
            if (string.Equals(keyString, "PK_ID"))
            {
                queryString += " WHERE " + keyString + " = " + keyValue;
            }
            else
            {
                queryString += " WHERE " + keyString + " = '" + keyValue + "'";
            }
            string connectionString = _config.GetConnectionString("Cafe1Context");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return RedirectToPage();

        }

        public IActionResult OnPostCreateData()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Dictionary<string, List<object>> tempTableData = TableData;
            tempTableData.Remove("__RequestVerificationToken");
            tempTableData.Remove("PK_ID");
            tempTableData.Remove("C_TABLE");
            string queryString = "INSERT INTO " + Request.Form["C_TABLE"] + " (";
            queryString += string.Join(',', tempTableData.Keys);
            queryString += ")";
            queryString += " VALUES (";
            List<string> queryArray = new List<string>();
            foreach (KeyValuePair<string, List<object>> entry in tempTableData)
            {
                queryArray.Add("N'" + Request.Form[entry.Key] + "'");
            }
            queryString += string.Join(",", queryArray);
            queryString += ")";
            string connectionString = _config.GetConnectionString("Cafe1Context"); ;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
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
            RowsCount = 0;
            string queryString = "SELECT " + string.Join(",", CurrentColumnNames) + " FROM  dbo." + CurrentCatalog.CTable;
            string connectionString = _config.GetConnectionString("Cafe1Context");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        RowsCount++;
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
                connection.Close();
            }
        }
    }
}
