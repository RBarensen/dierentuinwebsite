using Microsoft.AspNetCore.Mvc;
using rrwebsite.Models;
using System.Diagnostics;

namespace rrwebsite.Controllers
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
            return View();
        }
        public IActionResult Aap()
        {
            return View();
        }
        public IActionResult Dolfijn()
        {
            return View();
        }
        public IActionResult Leeuw()
        {
            return View();
        }
        public IActionResult Shows()
        {
            return View();
        }
        public IActionResult Giraffe()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            return View();
        }
        public IActionResult Tickets()
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