﻿using Microsoft.EntityFrameworkCore;
using SharedModels;
using System;

namespace DataLayer
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
