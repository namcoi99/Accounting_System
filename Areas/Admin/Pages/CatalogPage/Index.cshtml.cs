﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounting_System.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Accounting_System.Areas.Admin.Pages.CatalogPage
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly Cafe1Context _context;
        private readonly IConfiguration _config;
        private readonly INotyfService _notyf;
        public IndexModel(Cafe1Context context, IConfiguration config, INotyfService notyf)
        {
            _context = context;
            _config = config;
            _notyf = notyf;
        }
        public int? CurrentCatalogId { get; set; }
        public IList<TSysList> CatalogList { get; set; }
        public IList<TSysListdetail> CatalogListDetail { get; set; }
        public TSysList CurrentCatalog { get; set; }
        public IList<string> CurrentColumnNames { get; set; }
        [BindProperty]
        public Dictionary<string, List<object>> TableData { get; set; }
        public int RowsCount { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
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
                    .Where(item => item.FkList == CurrentCatalogId)
                    .Select(item => item.CName)
                    .ToListAsync();
                GetCurrentTableData();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Dictionary<string, List<object>> tempTableData = TableData;
            tempTableData.Remove("__RequestVerificationToken");
            tempTableData.Remove("C_TABLE");
            string keyString = "";
            string keyValue = "";
            string queryString = "UPDATE " + Request.Form["C_TABLE"] + " SET ";
            List<string> queryArray = new List<string>();
            foreach (KeyValuePair<string, List<object>> entry in tempTableData)
            {
                if (string.Equals(entry.Key, "PK_ID"))
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
            queryString += " WHERE " + keyString + " = " + keyValue;
            string connectionString = _config.GetConnectionString("Cafe1Context");
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                _notyf.Error("Có lỗi xảy ra khi sửa dữ liệu");
                return RedirectToPage();

            }
            _notyf.Success("Sửa dữ liệu thành công.");
            return RedirectToPage();

        }

        public IActionResult OnPostCreateData()
        {
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
            string connectionString = _config.GetConnectionString("Cafe1Context");
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                _notyf.Error("Có lỗi xảy ra khi thêm mới dữ liệu.");
                return RedirectToPage();
            }
            _notyf.Success("Tạo mới dữ liệu trong bảng " + Request.Form["C_TABLE"] + " thành công.");
            return RedirectToPage();
        }
        public IActionResult OnPostDeleteCatalogItem()
        {
            string queryString = "DELETE FROM " + Request.Form["C_TABLE"];
            queryString += " WHERE PK_ID = " + Request.Form["PK_ID"];
            string connectionString = _config.GetConnectionString("Cafe1Context");
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                _notyf.Error("Có lỗi xảy ra khi thêm mới dữ liệu.");
                return RedirectToPage();
            }
            _notyf.Success("Xóa dữ liệu trong bảng " + Request.Form["C_TABLE"] + " thành công.");
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

        public TSysListdetail GetCurrentListDetail(int id, string columnName)
        {
            return _context.TSysListdetail.Where(m => (m.FkList == id) && string.Equals(m.CName, columnName)).FirstOrDefault();
        }

    }
}
