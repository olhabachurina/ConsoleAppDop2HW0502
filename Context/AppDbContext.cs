using ConsoleAppDop2HW0502.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDop2HW0502.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BestClients;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-1), TotalAmount = 100.00m },
                new Order { OrderId = 2, CustomerId = 2, OrderDate = DateTime.Now.AddDays(-10), TotalAmount = 150.50m },
                new Order { OrderId = 3, CustomerId = 3, OrderDate = DateTime.Now.AddDays(-20), TotalAmount = 200.75m },
                new Order { OrderId = 4, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-2), TotalAmount = 99.95m },
                new Order { OrderId = 5, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-3), TotalAmount = 300.40m },
                new Order { OrderId = 6, CustomerId = 2, OrderDate = DateTime.Now.AddDays(-30), TotalAmount = 180.00m },
                new Order { OrderId = 7, CustomerId = 4, OrderDate = DateTime.Now.AddDays(-25), TotalAmount = 260.00m },
                new Order { OrderId = 8, CustomerId = 5, OrderDate = DateTime.Now.AddDays(-15), TotalAmount = 90.00m },
                new Order { OrderId = 9, CustomerId = 3, OrderDate = DateTime.Now.AddDays(-5), TotalAmount = 120.00m },
                new Order { OrderId = 10, CustomerId = 4, OrderDate = DateTime.Now.AddDays(-1), TotalAmount = 110.00m }
            );
        }
    }
}