using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ReactAspx.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Order> OrderItems { get; set; }    
        public DbSet<OrderDetail> OrderDetail { get; set; }

    }
}