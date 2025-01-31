using Microsoft.EntityFrameworkCore;
using dziennikzywieniowyAPI.Models;
using System.Collections.Generic;

namespace dziennikzywieniowyAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Entry> Entries { get; set; } 
        public DbSet<CaloricDeficit> CaloricDeficits { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
