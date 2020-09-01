using Daylinger.Models;
using System;

namespace Daylinger.Models
{
    public class EventWithContextIndex
    {
        public Guid Id { get; set; }
        public Event Event { get; set; }
        public int I { get; set; }
    }
}
