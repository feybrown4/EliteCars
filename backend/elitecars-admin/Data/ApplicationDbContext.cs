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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<RolePermission>()
            //composite primary key
            .HasKey(rp => new
            {
                rp.RolePermissionId,
                rp.RoleId,
                rp.PermissionId,
            });

        // relationship with role


        // relationship with role

        modelBuilder.Entity<CarMod>().HasKey(cm => new { cm.CarModId, cm.CarId });
        modelBuilder
            .Entity<CarMod>()
            .HasOne(c => c.Car)
            .WithMany(cm => cm.CarMods)
            .HasForeignKey(c => c.CarId);

        modelBuilder.Entity<CarOption>().HasKey(co => new { co.CarOptionId, co.CarId });
        modelBuilder
            .Entity<CarOption>()
            .HasOne(c => c.Car)
            .WithMany(co => co.CarOptions)
            .HasForeignKey(c => c.CarId);

        modelBuilder.Entity<Favorite>().HasKey(f => new { f.FavoriteId, f.CarId });
        modelBuilder
            .Entity<Favorite>()
            .HasOne(c => c.Car)
            .WithMany(f => f.Favorites)
            .HasForeignKey(c => c.CarId);
    }
}
