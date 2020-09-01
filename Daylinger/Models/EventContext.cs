using Microsoft.EntityFrameworkCore;
using Daylinger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daylinger.Data
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<BaseEvent> BaseEvents { get; set; }

        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
        }
    }
}
