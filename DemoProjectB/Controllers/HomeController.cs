using DemoProjectB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoProjectB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id)
        {
            // 

            var model = new UserModel()
            {
                FirstName = "Adriatik",
                LastName = "Ademi",
                Age = 15,
                Company = new()
                {
                    Name = "Comitas AG",
                    Address = "Rruga Musine Kokalari"
                }
            };

            return View(model);
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