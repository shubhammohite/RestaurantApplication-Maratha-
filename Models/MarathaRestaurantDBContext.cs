using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Maratha_Restaurant_Application.Models
{
    public class MarathaRestaurantDBContext:DbContext
    {
        public MarathaRestaurantDBContext(DbContextOptions<MarathaRestaurantDBContext> options):base(options)
        {
                
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<FoodItems> FoodItems { get; set; }
        public DbSet<OrderMasters> OrderMasters { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
