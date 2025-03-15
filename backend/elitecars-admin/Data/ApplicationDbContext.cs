using elitecars_admin.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    // Define DbSets - tables
    public DbSet<Car> Cars { get; set; }
    public DbSet<Admin> Admin { get; set; }

    public DbSet<CarMod> CarMods { get; set; }

    public DbSet<CarOption> CarOptions { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
}
