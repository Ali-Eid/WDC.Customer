using System;
using Microsoft.EntityFrameworkCore;
using WDC.Customers.Data.Entities;

namespace WDC.Customers.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }
    }
}

