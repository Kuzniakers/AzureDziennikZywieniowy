using dziennikzywieniowy.Models;
using Microsoft.EntityFrameworkCore;

namespace dziennikzywieniowy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Entry> Entries { get; set; } // Tabela Entries
        public DbSet<Product> Products { get; set; }
        public DbSet<CaloricDeficit> CaloricDeficits { get; set; }
    }
}
