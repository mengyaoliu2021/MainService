using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluffyFriend.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FluffyFriend.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class ManageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public ManageController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // GET: /<controller>/
        public IActionResult Profile()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return null;
            }

            string userid = "7a590435-7b2d-4c54-8c52-1ff5f956eb2d";
            return View(_context.UserProfiles.Find(userid));
        }

        // GET: /<controller>/
        public IActionResult EditProfile()
        {
            return View();
        }
    }
}
