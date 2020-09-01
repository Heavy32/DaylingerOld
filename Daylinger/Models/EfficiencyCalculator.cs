using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daylinger.Models
{
    public class EfficiencyCalculator
    {
        public float EfficiencyRating { get; set; }
        public float UnEfficiencyRaiting { get; set; }
        public TimeTable timeTable { get; set; }
        public DayTemplate template { get; set; }

        public EfficiencyCalculator(TimeTable timeTable, DayTemplate template)
        {
            this.timeTable = timeTable;
            this.template = template;
        }

        public void Calculate()
        {
            var events = timeTable.Events;
            var tempTimeInTemplate = template.hours[0].Start;
            var step = 5;

            for (int i = 0; i < template.hours.Length; i++)
            {
                while (tempTimeInTemplate != events[0].Start
                    && tempTimeInTemplate != template.hours[i + 1].Start)
                {
                    tempTimeInTemplate = tempTimeInTemplate.AddMinutes(step);
                }

                if (tempTimeInTemplate == events[0].Start)
                {
                    int eventTypeRating = 0;
                    int counter = 0;
                    float sum = 0;
                    while (tempTimeInTemplate != events[0].Finish)
                    {
                        if (tempTimeInTemplate == template.hours[i + 1].Start)
                        {
                            eventTypeRating = GetEventTypeRatingInPeriod(template.hours[i + 1], events[0]);
                            i++;
                        }

                        counter++;
                        var temp = (eventTypeRating * 100 / 5f);

                        EfficiencyRating = (sum + (eventTypeRating * 100 / 5f)) / counter;
                        sum += temp;
                        tempTimeInTemplate = tempTimeInTemplate.AddMinutes(step);
                    }
                    events.RemoveAt(0);
                }

                if (events.Count == 0)
                {
                    return;
                }
            }
        }

        private int GetEventTypeRatingInPeriod(Period period, Event @event)
        {
            return period.activitiesType.Where(e => e.GetType() == @event.EventType.GetType()).FirstOrDefault().EventRating;
        }
    }
}
