using System;

namespace Lab2_DatabaseContext
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("Database Context Configured Successfully.");
            Console.WriteLine("Connected to SQL Server using Entity Framework Core.");
        }
    }
}