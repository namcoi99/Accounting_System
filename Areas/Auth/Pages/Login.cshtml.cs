using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Accounting_System.Areas.Auth.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }
        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Nhớ thông tin đăng nhập?")]
            public bool RememberMe { get; set; }
        }
        public void OnGet()
        {
        }
    }
}
