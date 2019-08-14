using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                    : base(options)
        {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(Enumerable.Range(1, 3)
                .Select(i => new Category { Id = i, Name = $"Category {i}" })
                .ToArray());
            modelBuilder.Entity<Product>()
                .HasData(Enumerable.Range(1, 15)
                .Select(i => new Product { Id = i, Name = $"Product {i}", CategoryId = i%3 + 1 })
                .ToArray());

            base.OnModelCreating(modelBuilder);
        }
    }
}
