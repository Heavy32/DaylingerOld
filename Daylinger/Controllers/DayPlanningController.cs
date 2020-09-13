using Daylinger.Data;
using Daylinger.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daylinger.Controllers
{
    public class DayPlanningController : Controller
    {
        private readonly EventContext context;

        public DayPlanningController(EventContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            TempData.Put("TodayTimeTable", new List<Event>());
            return View();
        }
    }
    
}
