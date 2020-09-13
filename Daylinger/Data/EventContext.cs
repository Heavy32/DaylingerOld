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
        public DbSet<Person> People { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasOne(e => e.EventType)
                .WithMany(t => t.Events)
                .HasForeignKey(e => e.EventTypeId);

            modelBuilder.Entity<Person>()
                .HasMany(p => p.Events)
                .WithOne(e => e.Person)
                .HasForeignKey(p => p.PersonId);
        }
    }
}
