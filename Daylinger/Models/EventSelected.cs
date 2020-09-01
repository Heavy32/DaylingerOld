using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daylinger.Models
{
    public class EventSelected
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Event Event { get; set; }
        public bool isChecked { get; set; }
    }
}
