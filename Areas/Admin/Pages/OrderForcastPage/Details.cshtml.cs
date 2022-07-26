using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.OrderForcastPage
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly Cafe1Context _context;

        public DetailsModel(Cafe1Context context)
        {
            _context = context;
        }
        public class TDubaoctRecord
        {
            public TDubaoct Dubaoct { get; set; }
            public TDmVthh Vthh { get; set; }
            public TDmDvt Dvt { get; set; }
        }
        public List<SelectListItem> DvcsSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PhongbanSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> KhachhangSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> VattuhanghoaSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> DvtSelectList { get; set; } = new List<SelectListItem>();
        public IList<TDubaoctRecord> TDubaoctList { get; set; }
        [BindProperty]
        public TDubao TDubao { get; set; }
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public TDubaoct TDubaoct { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Id = (int)id;
            IList<TDmDvcs> TDvcs;
            IList<TDmPhongban> TDmPhongban;
            IList<TDmKh> TDmKh;
            IList<TDmVthh> TDmVthh;
            IList<TDmDvt> TDmDvt;

            TDvcs = _context.TDmDvcs.ToList();
            TDmPhongban = _context.TDmPhongban.ToList();
            TDmKh = _context.TDmKh.ToList();
            TDmVthh = _context.TDmVthh.ToList();
            TDmDvt = _context.TDmDvt.ToList();
            await Task.WhenAll();
            foreach (var item in TDvcs)
            {
                DvcsSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmPhongban)
            {
                PhongbanSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKh)
            {
                KhachhangSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CTen });
            }
            foreach (var item in TDmVthh)
            {
                VattuhanghoaSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmDvt)
            {
                DvtSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }

            TDubao = await _context.TDubao.FirstOrDefaultAsync(m => m.PkId == id);
            TDubaoctList = await _context.TDubaoct
                .Where(m => m.FkDubao == id)
                .GroupJoin(_context.TDmVthh, dubaoct => dubaoct.FkVthh, vthh => vthh.PkId,
                (dubaoct, vthhList) => new
                {
                    Dubaoct = dubaoct,
                    VthhList = vthhList
                })
                .SelectMany(
                   x => x.VthhList.DefaultIfEmpty(),
                   (x, y) => new TDubaoctRecord
                   {
                       Dubaoct = x.Dubaoct,
                       Vthh = y
                   })
                .GroupJoin(_context.TDmDvt, dubaoct => dubaoct.Dubaoct.FkDvban, dvt => dvt.PkId,
                (dubaoct, dvtList) => new
                {
                    Dubaoct = dubaoct.Dubaoct,
                    Vthh = dubaoct.Vthh,
                    DvtList = dvtList
                })
                .SelectMany(
                   x => x.DvtList.DefaultIfEmpty(),
                   (x, y) => new TDubaoctRecord
                   {
                       Dubaoct = x.Dubaoct,
                       Vthh = x.Vthh,
                       Dvt = y
                   })
                .ToListAsync();

            if (TDubao == null)
            {
                return NotFound();
            }
            return Page();
        }

        private bool TDubaoExists(int id)
        {
            return _context.TDubao.Any(e => e.PkId == id);
        }

        public async Task<IActionResult> OnPostUpdateCommonInfoAsync()
        {
            _context.Attach(TDubao).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TDubaoExists(TDubao.PkId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./Details", new { id = TDubao.PkId });
        }

        public async Task<IActionResult> OnPostCreateVthhAsync()
        {
            _context.TDubaoct.Add(TDubaoct);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Details", new { id = TDubaoct.FkDubao });
        }

        public async Task<IActionResult> OnPostDeleteVthhAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TDubaoct = await _context.TDubaoct.FindAsync(id);

            if (TDubaoct != null)
            {
                _context.TDubaoct.Remove(TDubaoct);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Details", new { id = TDubaoct.FkDubao }); ;
        }

        public void GetSelectedVthh(int id)
        {
            TDubaoct = _context.TDubaoct.Where(dubaoct => dubaoct.PkId == id).First();
        }

        public JsonResult OnPostGetSelectedDubaoct(int id)
        {
            TDubaoct = _context.TDubaoct.Where(dubaoct => dubaoct.PkId == id).First();
            return new JsonResult(TDubaoct);
        }
        public JsonResult OnPostGetSelectedProduct(int id)
        {
            var result = _context.TDmVthh.Where(vthh => vthh.PkId == id)
                .Join(_context.TDmDvt, vthh => vthh.FkDvban, dvt => dvt.PkId,
                (vthh,dvt) => new { 
                    Vthh = vthh,
                    Dvt = dvt
                })
                .First();
            return new JsonResult(result);
        }
    }
}
