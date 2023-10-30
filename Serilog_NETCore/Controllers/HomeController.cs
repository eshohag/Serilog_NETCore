using Microsoft.AspNetCore.Mvc;
using Serilog_NETCore.Models;
using System.Diagnostics;

namespace Serilog_NETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogInformation("HomeController controller called ");
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index get method Starting.");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy get method Starting.");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}