using Microsoft.EntityFrameworkCore;
using Lab5_RetrieveData.Models;

namespace Lab5_RetrieveData
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=RetailStoreDB;Trusted_Connection=True;");
        }
    }
}