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
        }

        protected override void Seed(Nmm.Models.NMMDb_D1 context)
        {
            context.Breweries.AddOrUpdate(n => n.Name,
                new Brewery()
                {
                    Name = "Johnny's Hops",
                    Address = "123 Main St",
                    City = "Empire",
                    State = "MI",
                    Zip = "46952"
                   
                },
                new Brewery()
                {
                    Name = "Billy's Brew",
                    Address = "50 E. Center St.",
                    City = "Cedar",
                    State = "MI",
                    Zip = "49522"

                   
                },
                new Brewery()
                {
                    Name = "Bobby's House of Beer",
                    Address = "405 S. Division",
                    City = "Traverse City",
                    State = "MI",
                    Zip = "49585"
                }

                );
        }
    }
}
