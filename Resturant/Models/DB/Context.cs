using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Resturant.Models.DB
{
    public class Context :DbContext 
    {
        public Context() : base ("Data Source=.;Initial Catalog=Resturants;Integrated Security=True") 
        { }

        public virtual DbSet<Resturant> Resturants { get; set; }
        public virtual DbSet<ResturantRate> ResturantRates { get; set; }
    }
}