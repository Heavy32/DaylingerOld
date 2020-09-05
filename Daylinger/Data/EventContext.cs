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
        public DbSet<EventType> EventTypes { get; set; }

        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasOne(e => e.EventType)
                .WithMany(t => t.Events)
                .HasForeignKey(e => e.EventTypeId);
        }
    }
}
