using _038_Net6nullableDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _038_Net6nullableDemo.Controllers
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
            TestModel model = new TestModel()
            {
                Id = 1,
                Name = null
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

        [HttpPost]
        public IActionResult Index(TestModel model)
        {
            // proje özelliklerinde nullable enable olduğu için model'deki Name zorunluluk validasyonuna takılır.
            // proje özelliklerinde nullable disable yaparsak .NET 5 ve .NET Framework'te olduğu gibi string? yerine string kullanabiliriz,
            // bu durum referans özellikleri için de geçerlidir.
            if (ModelState.IsValid) 
                return Content("Model is valid.");
            return Content("Model is not valid.");
        }
    }
}