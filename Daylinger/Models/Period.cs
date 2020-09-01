using System;
using System.Collections.Generic;

namespace Daylinger.Models
{
    public class Period
    {
        public List<EventType> activitiesType;
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }     
    }
}
