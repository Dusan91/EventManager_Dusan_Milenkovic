namespace EventsWeb.Migrations
{
    using EventsWeb.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EventsWeb.DbInfo.EventsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EventsWeb.DbInfo.EventsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
         
            context.Events.AddOrUpdate(
                new Models.Event
                    {
                        Name = "New Year",
                        Location = "Regent",
                        StartDate = new DateTime(2017, 12, 30),
                        EndDate = new DateTime(2018, 1, 2)
                    },
                 new Models.Event
                    {
                         Name = "Orthodox Christmas",
                         Location = "Hayat",
                         StartDate = new DateTime(2018, 1, 6),
                         EndDate = new DateTime(2018, 1, 7)
                    }
                );
           
        }
    }
}
