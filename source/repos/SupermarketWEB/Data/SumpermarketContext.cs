﻿using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;

namespace SupermarketWEB.Data
{
    public class SumpermarketContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PayMode> PayModes { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public SumpermarketContext(DbContextOptions options) : base(options)
        {
        }

    }
}
