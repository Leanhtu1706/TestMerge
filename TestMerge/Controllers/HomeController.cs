using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestMerge.Models;

namespace TestMerge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            var ilv = "Iloveyou";
            var goc = "goc";
            var merge = "Merge clone";
        }

        public IActionResult Index()
        {
            var abc = "hihihhi";
            var def = "hahahaaha";
            var hhh = "hhm";
            var change = "";

            return View();
            
        }

        public IActionResult Privacy()
        {
            var clonedung = "";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
