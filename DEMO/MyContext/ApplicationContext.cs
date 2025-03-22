using DEMO.Models;
using Microsoft.EntityFrameworkCore;

namespace DEMO.MyContext;

internal class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Delivery> Deliveries { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-3Q566FG\\ROMAN;Database=newdb;trusted_connection=True;TrustServerCertificate=True;");
    }
}
