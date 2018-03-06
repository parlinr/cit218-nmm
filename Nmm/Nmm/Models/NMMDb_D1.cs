using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Nmm.Models
{
    public class NMMDb_D1 : DbContext
    {
        public NMMDb_D1() : base("NMMDb_D1")
        {

        }

        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}