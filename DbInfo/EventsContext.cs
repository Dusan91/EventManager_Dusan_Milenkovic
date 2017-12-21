using EventsWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventsWeb.DbInfo
{
    public class EventsContext : DbContext
    {
        public EventsContext()
            : base("EventsConnection")
        { }

        public DbSet<Event> Events { get; set; }
    }
}