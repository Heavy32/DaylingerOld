using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Daylinger.Data;
using Daylinger.Models;

namespace Daylinger.Controllers
{
    public class EventsController : Controller
    {
        private readonly EventContext context;
        private readonly DaylingerLogic daylinger;

        public EventsController(EventContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {           
            if (context.BaseEvents.Count() == 0)
            {
                var template = new PerfectDayOfAveragePerson();
                context.BaseEvents.AddRange(template.BaseEvents);
                context.SaveChanges();
            }

            var unsetBaseEvents = new List<BaseEvent>();
            foreach (var item in context.BaseEvents)
            {
                if (item is BaseEvent)
                {
                    if (item.Start == default)
                    {
                        unsetBaseEvents.Add(item);
                    }
                }
            }

            if (unsetBaseEvents.Count != 0)
            {
                TempData.Put("BaseEvents", unsetBaseEvents);
                return RedirectToAction("BaseEvents");
            }

            return View(context.Events);
        }

        public IActionResult EditAllBaseEvents()
        {
            var a = context.Events.ToList(); //WHY THE FUCK DOESN'T THIS ACTION WORK WITHOUT IT??? 

            int i = Convert.ToInt32(TempData["i"]);
            var eventToUpdate = context.Events.Local.ElementAt(i);
            i++;
            TempData["i"] = i;
            return View(eventToUpdate);
        }

        public IActionResult BaseEvents()
        {
            var unsetBaseEvents = TempData.Get<List<BaseEvent>>("BaseEvents");
            return View(unsetBaseEvents);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAllBaseEvents(Guid Id, BaseEvent inputEvent)
        {
            var a = context.BaseEvents.ToList(); //WHY THE FUCK DOESN'T THIS ACTION WORK WITHOUT IT??? 

            var e = context.BaseEvents.Find(Id);
            e.Name = inputEvent.Name;
            context.SaveChanges();

            //var local = context.Set<BaseEvent>().Local.FirstOrDefault(entry => entry.Id.Equals(Id));
            //if (local != null)
            //{
            //    context.Entry(local).State = EntityState.Detached;
            //}
            //context.Entry(inputEvent).State = EntityState.Modified;
            //context.SaveChanges();

            int i = Convert.ToInt32(TempData["i"]);

            if (i == context.Events.Count())
            {
                return RedirectToAction("SetUsersEvents");
            }

            return RedirectToAction("EditAllBaseEvents", "Events");
        }

        public IActionResult Edit(int Id)
        {
            var baseEvent = daylinger.DayTemplate.BaseEvents[Id];
            return View(daylinger.DayTemplate.BaseEvents);
        }

        public IActionResult AddToTimeTable()
        {
            return RedirectToAction("SetUsersEvents");
        }

        public IActionResult SetUsersEvents()
        {
            return View(context.Events.Where(e => !(e is BaseEvent)));
        }

        public IActionResult Construct()
        {
            var template = new PerfectDayOfAveragePerson();
            var t = context.Events.ToList();
            DayConstructor constructor = new DayConstructor(context.Events.ToList(), template);
            constructor.CalculateTimeTable();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EventInput eventInput)
        {
            var eventType = new EventType();
                
            if(eventInput.EventType == "Work")
            {
                eventType = new Work();
            }

            Event @event = new Event
            {
                Description = eventInput.Description,
                Id = Guid.NewGuid(),
                EventType = eventType,
                Name = eventInput.Name,
                DurationInMinutes = eventInput.DurationInMinutes
            };

            context.Events.Add(@event);
            context.SaveChanges();
            return RedirectToAction("SetUsersEvents");
        }
    }
}
