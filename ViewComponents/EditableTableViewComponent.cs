using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting_System.ViewComponents
{
    public class EditableTableViewComponent : ViewComponent
    {
        private readonly Cafe1Context _context;
        public EditableTableViewComponent(Cafe1Context context)
        {
            _context = context;
        }
        public Dictionary<string, List<object>> TableData { get; set; }
        public IList<TSysListdetail> CatalogListDetail { get; set; }
        public TSysList CurrentCatalog { get; set; }
        public IList<string> CurrentColumnNames { get; set; }
        public string CatalogTableName { get; set; }
        public string[] ColumnNames { get; set; }
        public int RowsCount { get; set; }
        public async Task<IViewComponentResult> InvokeAsync(string catalogTableName)
        {
            Console.WriteLine(catalogTableName);
            CatalogTableName = catalogTableName;
            if (CatalogTableName != null)
            {
                CurrentCatalog = await _context.TSysList
                        .Where(item => item.CTable == CatalogTableName)
                        .FirstOrDefaultAsync();
                if(CurrentCatalog != null)
                {
                    CatalogListDetail = await _context.TSysListdetail
                        .Where(item => item.FkList == CurrentCatalog.PkId && item.CVisible == true)
                        .ToListAsync();
                    CurrentColumnNames = await _context.TSysListdetail
                        .Where(item => item.FkList == CurrentCatalog.PkId && item.CVisible == true)
                        .Select(item => item.CName)
                        .ToListAsync();
                    GetCurrentTableData();
                    return View(new CommonTableData(CurrentCatalog, CatalogListDetail, TableData, RowsCount));
                }
            }
            return View(new CommonTableData());
        }

        public async Task<IViewComponentResult> OnPostCreateDataAsync()
        {
            string keyString = "";
            string keyValue = "";
            string queryString = "UPDATE " + Request.Form["C_TABLE"] + " SET ";
            List<string> queryArray = new List<string>();
            foreach (KeyValuePair<string, List<object>> entry in TableData)
            {
                if (string.Equals(entry.Key, "PK_ID") | string.Equals(entry.Key, "C_MA"))
                {
                    keyString = entry.Key;
                    keyValue = Request.Form[entry.Key];
                }
                else if (!string.Equals(entry.Key, "C_TABLE"))
                {
                    queryArray.Add(entry.Key + " = N'" + Request.Form[entry.Key] + "'");
                }
            }
            queryArray.RemoveAt(queryArray.Count - 1);
            queryString += string.Join(",", queryArray);
            if (string.Equals(keyString, "PK_ID"))
            {
                queryString += " WHERE " + keyString + " = " + keyValue;
            }
            else
            {
                queryString += " WHERE " + keyString + " = '" + keyValue + "'";
            }
            string connectionString = Constants.CONNECTION_STRING;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                await command.ExecuteNonQueryAsync();
                connection.Close();
            }

            TSysList CurrentCatalog = await _context.TSysList
                        .Where(item => item.CTable == Request.Form["C_TABLE"])
                        .FirstOrDefaultAsync();
            if (CurrentCatalog != null)
            {
                IList<TSysListdetail> CatalogListDetail = await _context.TSysListdetail
                    .Where(item => item.FkList == CurrentCatalog.PkId && item.CVisible == true)
                    .ToListAsync();
                IList<string> CurrentColumnNames = await _context.TSysListdetail
                    .Where(item => item.FkList == CurrentCatalog.PkId && item.CVisible == true)
                    .Select(item => item.CName)
                    .ToListAsync();
            }
            return View(new CommonTableData());

        }

        private void GetCurrentTableData()
        {
            TableData = new Dictionary<string, List<object>>();

            for (int i = 0; i < CurrentColumnNames.Count; i++)
            {
                TableData.Add(CurrentColumnNames[i], new List<object>());
            }
            RowsCount = 0;
            string queryString = "SELECT " + string.Join(",", CurrentColumnNames) + " FROM  dbo." + CatalogTableName;
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
