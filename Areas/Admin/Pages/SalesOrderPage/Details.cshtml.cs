using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Accounting_System.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Accounting_System.Areas.Admin.Pages.SalesOrderPage
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly Cafe1Context _context;

        public DetailsModel(Cafe1Context context)
        {
            _context = context;
        }
        public class TDondathangctRecord
        {
            public TDondathangct Dondathangct { get; set; }
            public TDmVthh Vthh { get; set; }
            public TDmDvt Dvt { get; set; }
        }
        public class TDondathangdkRecord
        {
            public TDondathangdk Dondathangdk { get; set; }
            public TDmDkbg Dkbg { get; set; }
        }
        public IList<TDondathangctRecord> TDondathangctList { get; set; }
        public IList<TDondathangdkRecord> TDondathangdkList { get; set; }
        [BindProperty]
        public TDondathang TDondathang { get; set; }
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public TDondathangct TDondathangct { get; set; }
        [BindProperty]
        public TDondathangdk TDondathangdk { get; set; }
        public List<SelectListItem> DvcsSelectList { get; set; } = new List<SelectListItem>();
        //public List<SelectListItem> LoaiBgSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> KhSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TienteSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> NlhSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> VuviecSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PhongbanSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PhanxuongSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> VattuhanghoaSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PtttSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> DkbgSelectList { get; set; } = new List<SelectListItem>();
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
            TDondathangctList = _context.TDondathangct
                .Where(item => item.FkDondathang == id)
                .GroupJoin(_context.TDmVthh, ddhct => ddhct.FkVthh, vthh => vthh.PkId,
                (ddhct, vthhList) => new
                {
                    Dondathangct = ddhct,
                    VthhList = vthhList
                })
                .SelectMany(
                   x => x.VthhList.DefaultIfEmpty(),
                   (x, y) => new TDondathangctRecord
                   {
                       Dondathangct = x.Dondathangct,
                       Vthh = y
                   })
                .GroupJoin(_context.TDmDvt, ddhct => ddhct.Dondathangct.FkDvban, dvt => dvt.PkId,
                (ddhct, dvtList) => new
                {
                    Dondathangct = ddhct.Dondathangct,
                    Vthh = ddhct.Vthh,
                    DvtList = dvtList
                })
                .SelectMany(
                   x => x.DvtList.DefaultIfEmpty(),
                   (x, y) => new TDondathangctRecord
                   {
                       Dondathangct = x.Dondathangct,
                       Vthh = x.Vthh,
                       Dvt = y
                   })
                .ToList();
            TDondathangdkList = _context.TDondathangdk
                .Where(item => item.FkDondathang == id)
                .Join(_context.TDmDkbg, ddhdk => ddhdk.FkDkbg, dkbg => dkbg.PkId,
                (ddhdk, dkbg) => new TDondathangdkRecord
                {
                    Dondathangdk = ddhdk,
                    Dkbg = dkbg
                }).ToList();
            await Task.WhenAll();
            if (TDondathang == null)
            {
                return NotFound();
            }
            IList<TDmVthh> TDmVthh;
            IList<TDmDkbg> TDmdkbg;
            IList<TDmXe> TDmXe;
            IList<TDmDvcs> TDvcs;
            IList<TDmKh> TDmKh;
            IList<TDmTiente> TDmTiente;
            IList<TDmKhnlh> TDmKhnlh;
            IList<TDmVuviec> TDmVuviec;
            IList<TDmPhongban> TDmPhongban;
            IList<TDmPhanxuong> TDmPhanxuong;
            //IList<TDmLoaibg> TDmLoaibg;
            IList<TDmPttt> TDmPttt;
            IList<TDmDkbg> TDmDkbg;
            TDvcs = _context.TDmDvcs.ToList();
            TDmKh = _context.TDmKh.ToList();
            TDmTiente = _context.TDmTiente.ToList();
            TDmKhnlh = _context.TDmKhnlh.ToList();
            TDmVuviec = _context.TDmVuviec.ToList();
            TDmPhongban = _context.TDmPhongban.ToList();
            TDmPhanxuong = _context.TDmPhanxuong.ToList();
            TDmVthh = _context.TDmVthh.ToList();
            //TDmLoaibg = _context.TDmLoaibg.ToList();
            TDmPttt = _context.TDmPttt.ToList();
            TDmDkbg = _context.TDmDkbg.ToList();
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
            foreach (var item in TDvcs)
            {
                DvcsSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKh)
            {
                KhSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmTiente)
            {
                TienteSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmKhnlh)
            {
                NlhSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CTen });
            }
            foreach (var item in TDmVuviec)
            {
                VuviecSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmPhongban)
            {
                PhongbanSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            foreach (var item in TDmPhanxuong)
            {
                PhanxuongSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            //foreach (var item in TDmLoaibg)
            //{
            //    LoaiBgSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMota });
            //}
            foreach (var item in TDmPttt)
            {
                PtttSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMota });
            }
            foreach (var item in TDmDkbg)
            {
                DkbgSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMota });
            }
            return Page();
        }

        public async Task<IActionResult> OnPostUpdateCommonInfoAsync()
        {
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

        public async Task<IActionResult> OnPostUpdateTtvcAsync()
        {
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
        public JsonResult OnPostGetSelectedProduct(int id)
        {
            var result = _context.TDmVthh.Where(vthh => vthh.PkId == id).First();
            return new JsonResult(result);
        }
        public JsonResult OnPostGetSelectedCustomer(int id)
        {
            var result = _context.TDmKh.Where(kh => kh.PkId == id).First();
            return new JsonResult(result);
        }
    }
}
