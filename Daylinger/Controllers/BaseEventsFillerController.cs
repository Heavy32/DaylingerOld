using Daylinger.Data;
using Daylinger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daylinger.Controllers
{
    public class BaseEventsFillerController : Controller
    {
        private readonly EventContext context;

        public BaseEventsFillerController(EventContext context)
        {
            this.context = context;
            var t = context.Events.Include(e => e.EventType).ToArray(); 
        }

        public IActionResult Index()
        {
            TempData.Put("TodayTimeTable", new List<Event>());
        }

        //https://localhost:44311/BaseEventsFiller/BaseEvents/1
        public IActionResult BaseEvents(int Id)
        {
            var person = context.People.Include(p => p.Events).Where(p => p.Id == Id).FirstOrDefault();
            var baseEvents = new Queue<Event>(person.Events.Where(e => e.EventType.Name == "Base"));
            TempData.Put("EventsQueue", baseEvents);

            return View(baseEvents);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var queue = TempData.Get<Queue<Event>>("EventsQueue");

            if(queue.Count == 0)
            {
                TempData.Remove("EventsQueue");
                return RedirectToAction("BaseEvents", new { Id = 1 });
            }

            var @event = queue.Dequeue();
            TempData.Put("EventsQueue", queue);
            return View(@event);
        }

        [HttpPost]
        public IActionResult Edit(int Id, Event @event)
        {
            var e = context.Events.Find(@event.Id);
            e.Name = @event.Name;
            context.SaveChanges();
            return RedirectToAction("Edit");
        }
    }
}
