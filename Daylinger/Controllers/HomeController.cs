using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Daylinger.Models;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using DHTMLX.Scheduler;
using Daylinger.Data;

namespace Daylinger.Controllers
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

        public IActionResult Test()
        {
            return View();
        }
    }
}
