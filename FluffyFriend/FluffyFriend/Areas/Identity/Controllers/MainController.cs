using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluffyFriend.Areas.Identity.Models;
using FluffyFriend.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FluffyFriend.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class MainController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public MainController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }

        // POST: Todos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Email, Password")] LoginModel data)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync("username_" + data.Email,
                           data.Password, true, lockoutOnFailure: true);
                if (result.Succeeded)
                {

                    return LocalRedirect("~/Home");
                }
                return RedirectToAction(nameof(Login));
            }
            return View(data);
        }

        // GET: /<controller>/
        public IActionResult Register()
        {
            return View();
        }

        // POST: Todos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Username, Email, Password")] LoginModel loginInfo)
        {

            if (ModelState.IsValid)
            {

                var user = new IdentityUser { UserName = loginInfo.Username, Email = loginInfo.Email };
                var result = await _userManager.CreateAsync(user, loginInfo.Password);
                if (result.Succeeded)
                {

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    return Redirect(callbackUrl);
                }
            }
            return View(loginInfo);
        }
    }

}
