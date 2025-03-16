using elitecars_admin.Models;
using Microsoft.EntityFrameworkCore;

namespace elitecars_admin.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    // Define DbSets - tables
    public DbSet<Car> Cars => Set<Car>();
    public DbSet<Admin> Admin => Set<Admin>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<CarMod> CarMods => Set<CarMod>();

    public DbSet<CarOption> CarOptions => Set<CarOption>();
    public DbSet<Cart> Carts => Set<Cart>();
    public DbSet<Favorite> Favorites { get; set; } = null!;
    public DbSet<Inventory> Inventories { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<Permission> Permissions { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<RolePermission> RolePermissions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder) { }
}
