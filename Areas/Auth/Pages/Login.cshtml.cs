using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Accounting_System.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Accounting_System.Areas.Auth.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;
        private readonly Cafe1Context _context;

        public LoginModel(ILogger<LoginModel> logger, Cafe1Context context)
        {
            _logger = logger;
            _context = context;
        }
        [BindProperty]
        public InputModel Input { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }
        public class InputModel
        {
            [Required(ErrorMessage = "Tên đăng nhập không được để trống.")]
            //[EmailAddress]
            public string Username { get; set; }

            [Required(ErrorMessage = "Mật khẩu không được để trống.")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Nhớ thông tin đăng nhập?")]
            public bool RememberMe { get; set; }
        }
        public string ReturnUrl { get; set; }
        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // Clear the existing external cookie
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                var user = _context.TSysAccount
                    .Where(account => account.CMa == Input.Username)
                    .FirstOrDefault();
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Sai thông tin đăng nhập / mật khẩu.");
                    return Page();
                }
                if (!BCrypt.Net.BCrypt.Verify(Input.Password, user.CMatkhau)) {
                    ModelState.AddModelError(string.Empty, "Sai thông tin đăng nhập / mật khẩu.");
                    return Page();
                }
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.CMa),
                    new Claim(ClaimTypes.NameIdentifier, user.PkId.ToString()),
                    new Claim(ClaimTypes.Role, "Administrator"),
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    //IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                _logger.LogInformation("User {Username} logged in at {Time}.",
                    Input.Username, DateTime.UtcNow);

                return LocalRedirect(returnUrl);
            }

            // Something failed. Redisplay the form.
            return Page();
        }
    }
}
