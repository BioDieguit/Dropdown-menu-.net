using Herdez_Requisiciones.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Herdez_Requisiciones.Controllers
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

        public IActionResult Herdez()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Herdez(Direcciones direcciones)
        {
            return View(direcciones.URL);
        }

        public IActionResult Privacy()
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