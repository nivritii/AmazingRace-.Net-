using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AmazingRace.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AmazingRace.DAL
{
    public class EventContext : DbContext
    {
        public EventContext() : base("EventContext")
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}