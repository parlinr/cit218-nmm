namespace Nmm.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Nmm.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Nmm.Models.NMMDb_D1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Nmm.Models.NMMDb_D1";
        }

        protected override void Seed(Nmm.Models.NMMDb_D1 context)
        {
            context.Breweries.AddOrUpdate(b => b.Name,
                new Brewery
                {
                    Name = "Johnny's Hops",
                    Address = "123 Main St",
                    City = "Suttons Bay",
                    State = "MI",
                    Zip = "49674"
                },
                new Brewery
                {
                    Name = "Billy's Brew",
                    Address = "456 Center Dr",
                    City = "Empire",
                    State = "MI",
                    Zip = "49666"

                },
                new Brewery
                {
                    Name = "Suzy's Suds",
                    Address = "789 2nd St",
                    City = "Maple City",
                    State = "MI",
                    Zip = "49659"
                }

                );
        }
    }
}
