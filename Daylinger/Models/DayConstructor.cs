using Daylinger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daylinger.Models
{
    public class DayConstructor
    {
        private readonly List<Event> events;
        private readonly DayTemplate template;
        public TimeTable timeTable;

        public DayConstructor(List<Event> events, DayTemplate template)
        {
            this.template = template;
            this.events = events;
            timeTable = new TimeTable();
            timeTable.Events.AddRange(events);
        }

        public void CalculateTimeTable()
        {
            for (int i = 0; i < events.Count; i++)
            {
                if (!(events[i] is BaseEvent))
                {
                    FindTimeForEvent(events[i], 5);
                }
            }
        }

        public void FindTimeForEvent(Event @event, int step)
        {
            int maxRating = 5;
            while (maxRating != 0)
            {
                foreach (var period in template.hours)
                {                   
                    var eventTypeRatingInPeriod = GetEventTypeRatingInPeriod(period, @event);
                    var timeToCheck = period.Start;
                    while (timeToCheck != period.Finish)
                    {
                        if (eventTypeRatingInPeriod == maxRating && timeTable.IsTimeFree(new Event { Start = timeToCheck, Finish = timeToCheck.AddMinutes(@event.DurationInMinutes) }))
                        {
                            @event.Start = timeToCheck;
                            @event.Finish = timeToCheck.AddMinutes(@event.DurationInMinutes);
                            timeTable.SetEvent(@event);
                            return;
                        }
                        timeToCheck = timeToCheck.AddMinutes(step);
                    }
                }
                maxRating--;
            }
        }

        private int GetEventTypeRatingInPeriod(Period period, Event deal)
        {
            return period.activitiesType.Where(e => e?.GetType() == deal.EventType.GetType()).FirstOrDefault().EventRating;
        }
    }
}
