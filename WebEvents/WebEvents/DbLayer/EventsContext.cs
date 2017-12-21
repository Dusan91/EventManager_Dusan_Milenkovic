using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebEvents.Models;

namespace WebEvents.DbLayer
{
    public class EventsContext : DbContext
    {
        public EventsContext()
            : base("EventsConnection")
        { }

        public DbSet<Event> Events { get; set; }
    }
}