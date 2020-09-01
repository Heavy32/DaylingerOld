using System;
using System.Collections.Generic;

namespace Daylinger.Models
{
    public class TimeTable
    {
        public List<Event> Events { get; set; }

        public TimeTable()
        {
            Events = new List<Event>();
        }

        public void SetEvent(Event deal)
        {
            Events.Add(deal);
        }

        public void DeleteEvents(Event deal)
        {
            if (Events.Contains(deal))
            {
                Events.Remove(deal);
            }
            else
            {
                throw new Exception("Nothing to delete");
            }
        }

        public bool IsTimeFree(Event deal)
        {
            if (Events.Count == 0)
                return true;

            var event2Start = deal.Start;
            var event2Finish = deal.Finish;

            foreach (var item in Events)
            {
                var event1Start = item.Start;
                var event1Finish = item.Finish;

                if (event1Start == event2Start && event1Finish == event2Finish)
                    return false;

                if (!(((event1Start < event2Start) && (event1Finish <= event2Start)
                        && (event1Start <= event2Finish) && (event1Finish < event2Finish))
               || ((event2Start < event1Start) && (event2Finish <= event1Start)
                        && (event2Start <= event1Finish) && (event2Finish < event1Finish))))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
