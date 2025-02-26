using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UsersApp.Models;

namespace UsersApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            if (User.Identity.IsAuthenticated)
            {
                return View(); // Show the actual home page
            }
            return RedirectToAction("Login", "Account");
        }

        [Authorize]
        public IActionResult Privacy()
        {

            if (User.Identity.IsAuthenticated)
            {
                return View(); // Show the actual home page
            }
            return RedirectToAction("Login", "Account");
        }
        //public IActionResult Privacy()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        return RedirectToAction("Index", "Home"); // Redirect to home if logged in
        //    }

        //    return RedirectToAction("Login", "Account"); // Redirect to login if not authenticated
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
