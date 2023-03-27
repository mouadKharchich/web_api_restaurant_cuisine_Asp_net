using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContexts
{
    public class RestaurantContext:DbContext
    {

        public RestaurantContext(DbContextOptions<RestaurantContext> options):base(options)
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Cuisine> Cuisines { get; set;}
    }
}
