using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestASP.NET.Models;

namespace SUNVODZ.Controllers
{
    public class BeersController : Controller
    {

        ILogger<BeersController> _logger;

        public BeersController(ILogger<BeersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public string run(){
            return "running";
        }

        public IActionResult ViewBeer()
        {
            IEnumerable<Beers> _data = new List<Beers>
            {
                new Beers(){
                    Name = "Chang",
                    Calorie = "120 Calorie",
                    Price = "55 B",
                },
                new Beers(){
                    Name = "Leo",
                    Calorie = "150 Calorie",
                    Price = "60 B",
                }
            };
            return View(_data);
        }
    }
}