using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daylinger.Models
{
    public class DayTemplate : IBaseEvent
    {
        public Period[] hours;
        public List<BaseEvent> BaseEvents { get; set; }
    }
}
