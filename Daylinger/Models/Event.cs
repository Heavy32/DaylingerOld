using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daylinger.Models
{
    public class Event
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }
    }
}
