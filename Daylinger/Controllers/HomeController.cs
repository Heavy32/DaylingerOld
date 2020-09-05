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
    public class Test
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
    }

    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
                : base(options)
        {
        }
        public DbSet<Test> Tests { get; set; }
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly TestDbContext context;
        private readonly EventContext context;

        public HomeController(ILogger<HomeController> logger, EventContext context)
        {
            this.context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            context.EventTypes.Add(new EventType
            {
                Id = 1,
                Name = "Work"
            });
            context.SaveChanges();

            TempData["i"] = 0;

            context.SaveChanges();
            return View();  
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
