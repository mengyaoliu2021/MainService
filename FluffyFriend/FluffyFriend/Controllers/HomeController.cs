using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FluffyFriend.Models;
using FluffyFriend.Data;
using Microsoft.EntityFrameworkCore;

namespace FluffyFriend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var Posts = await _context.Posts.Join(
                _context.Users,
                post => post.UserId,
                user => user.Id,
                (post, user) =>
                new
                {
                    postUser = user.Id,
                    PostUserEmail = user.Email,
                    PostTime = post.CreatedDate,
                    PostMessage = post.Message,
                    PostImage = post.Photo
                }
                ).ToListAsync();
            return View(await _context.Posts.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TestPage2()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
