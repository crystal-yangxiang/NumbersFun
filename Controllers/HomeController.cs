using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NumbersFun.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NumbersFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/numberPage")]
        public IActionResult ConvertWholeNumber(string number)
        {
            Number newNum = new Number();
            newNum.EndWord = Number.ConvertWholeNumber(number);
            return View(newNum);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
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
