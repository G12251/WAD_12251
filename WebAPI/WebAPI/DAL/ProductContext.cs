﻿using WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.DAL
{
    public class ProductContext:DbContext
    {
        // Constructer
        public ProductContext(DbContextOptions<ProductContext> o) : base(o) 
        {
            Database.EnsureCreated();
        }

        // Product Database
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
