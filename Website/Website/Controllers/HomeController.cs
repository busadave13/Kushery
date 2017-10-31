using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpGet("location/{name}")]
        public IActionResult Location(string name)
        {
      
            ViewData["LocationName"] = name;

            return View();
        }

        [HttpGet("clearview")]
        public IActionResult Clearview()
        {
            return View();
        }

        [HttpGet("Lake Forest Park")]
        public IActionResult LakeForestPark()
        {
            return View();
        }

        [HttpGet("cathcart")]
        public IActionResult Cathcart()
        {            
            return View();
        }

        [HttpGet("events")]
        public IActionResult Events()
        {            
            return View();
        }

        public IActionResult Specials()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
