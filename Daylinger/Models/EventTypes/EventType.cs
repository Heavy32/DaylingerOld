using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Daylinger.Models
{
    public class EventType
    {
        [Key]
        public int Id { get; set; }
        public int EventRating { get; set; }
    }
}
