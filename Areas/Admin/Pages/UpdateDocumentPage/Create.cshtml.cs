using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using AspNetCoreHero.ToastNotification.Abstractions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Accounting_System.Areas.Admin.Pages.UpdateDocumentPage
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Cafe1Context _context;
        private readonly INotyfService _notyf;
        public CreateModel(Cafe1Context context, INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
        }
        [BindProperty]
        public string SoPhieu { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        [DisplayName("Ngày lập")]
        public DateTime NgayLap { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "{0} là trường bắt buộc")]
        [DisplayName("C.từ")]
        public int FkChungTu { get; set; }
        [BindProperty]
        public TXntcorder TXntcorder { get; set; } = new TXntcorder();
        public List<SelectListItem> TDmDvcsSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> TDmChungtuSelectList { get; set; } = new List<SelectListItem>();

        public async Task<IActionResult> OnGetAsync()
        {
            IList<TDmChungtu> TDmChungtu;
            IList<TDmDvcs> TDmDvcs;
            TDmChungtu = _context.TDmChungtu.OrderBy(ct => ct.CMa).ToList();
            TDmDvcs = _context.TDmDvcs.ToList();
            await Task.WhenAll();

            foreach (var item in TDmChungtu)
            {
                TDmChungtuSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa + " - " + item.CTen });
            }
            foreach (var item in TDmDvcs)
            {
                TDmDvcsSelectList.Add(new SelectListItem { Value = item.PkId.ToString(), Text = item.CMa });
            }
            NgayLap = DateTime.Now;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            TXntcorder xntcOrder = await _context.TXntcorder.Where(m => string.Equals(m.CSophieu, TXntcorder.CSophieu)).FirstOrDefaultAsync();
            if (xntcOrder != null)
            {
                _notyf.Error("Chứng từ với số phiếu " + TXntcorder.CSophieu + " đã tồn tại");
                return RedirectToPage("./Create");
            }
            _context.TXntcorder.Add(TXntcorder);
            await _context.SaveChangesAsync();
            _notyf.Success("Tạo mới thành công.");
            return RedirectToPage("./Details", new { id = TXntcorder.PkId });
        }

        public JsonResult OnPostGetSelectedDocument(int id)
        {
            var result = _context.TDmChungtu.Where(ct => ct.PkId == id).First();
            return new JsonResult(result);
        }
    }
}
