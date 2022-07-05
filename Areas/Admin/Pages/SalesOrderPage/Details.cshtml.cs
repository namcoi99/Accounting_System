using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Accounting_System.Areas.Admin.Pages.SalesOrderPage
{
    public class DetailsModel : PageModel
    {
        private readonly Accounting_System.Models.Cafe1Context _context;

        public DetailsModel(Accounting_System.Models.Cafe1Context context)
        {
            _context = context;
        }
        public TDondathang TDondathang { get; set; }
        public IList<TDondathangct> TDondathangctList { get; set; }
        public IList<TDondathangdk> TDondathangdkList { get; set; }
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public TDondathangct TDondathangct { get; set; }
        [BindProperty]
        public TDondathangdk TDondathangdk { get; set; }
        public List<SelectListItem> VattuhanghoaSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> DieukhoanbaogiaSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> DMXeSelectList { get; set; } = new List<SelectListItem>();


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Id = (int)id;
            TDondathang = await _context.TDondathang.FirstOrDefaultAsync(m => m.PkId == id);
            TDondathangctList = _context.TDondathangct.Where(item => item.FkDondathang == id).ToList();
            TDondathangdkList = _context.TDondathangdk.Where(item => item.FkDondathang == id).ToList();
            await Task.WhenAll();
            if (TDondathang == null)
            {
                return NotFound();
            }
            IList<TDmVthh> TDmVthh;
            IList<TDmDkbg> TDmdkbg;
            IList<TDmXe> TDmXe;
            TDmVthh = _context.TDmVthh.ToList();
            TDmdkbg = _context.TDmDkbg.ToList();
            TDmXe = _context.TDmXe.ToList();

            await Task.WhenAll();
            foreach (var item in TDmVthh)
            {
                VattuhanghoaSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmdkbg)
            {
                DieukhoanbaogiaSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMota });
            }
            foreach (var item in TDmXe)
            {
                DMXeSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CSoxe });
            }
            return Page();
        }

        public async Task<IActionResult> OnPostUpdateTtvcAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TDondathang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TDondathangExists(TDondathang.PkId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Details", new { id = TDondathang.PkId });
        }

        public async Task<IActionResult> OnPostCreateVthhAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.TDondathangct.Add(TDondathangct);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Details", new { id = TDondathangct.FkDondathang });
        }

        public async Task<IActionResult> OnPostDeleteVthhAsync(int? id, int orderId)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDondathangct = await _context.TDondathangct.FindAsync(id);

            if (TDondathangct != null)
            {
                _context.TDondathangct.Remove(TDondathangct);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Details", new { id = orderId }); ;
        }

        public async Task<IActionResult> OnPostCreateDkbgAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.TDondathangdk.Add(TDondathangdk);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Details", new { id = TDondathangdk.FkDondathang });
        }

        public async Task<IActionResult> OnPostDeleteDkbgAsync(int? id, int orderId)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDondathangdk = await _context.TDondathangdk.FindAsync(id);

            if (TDondathangdk != null)
            {
                _context.TDondathangdk.Remove(TDondathangdk);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Details", new { id = orderId }); ;
        }

        private bool TDondathangExists(int id)
        {
            return _context.TDondathang.Any(e => e.PkId == id);
        }

        public TDmDkbg GetDkbgbyId(int id)
        {
            return _context.TDmDkbg.FirstOrDefault(item => item.PkId == id);
        }

        public TDmVthh GetVthhbyId(int id)
        {
            return _context.TDmVthh.FirstOrDefault(item => item.PkId == id);
        }
    }
}
