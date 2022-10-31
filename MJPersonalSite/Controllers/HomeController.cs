using Microsoft.AspNetCore.Mvc;
using MJPersonalSite.Models;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace MJPersonalSite.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Links()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        
        
        
        //private readonly IConfiguration _config;
        ////Add a constructor for our controller that accepts the config info as a parameter
        //public HomeController(IConfiguration config)
        //{
        //    _config = config;
        //}


    }
}