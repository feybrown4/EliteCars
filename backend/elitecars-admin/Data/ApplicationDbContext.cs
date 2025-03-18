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

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

       // modelBuilder.Entity<RolePermission>()
                //composite primary key
                //.HasKey(rp => new { rp.RolePermissionId, rp.RoleId, rp.PermissionId });

        // relationship with role


        // relationship with role

        modelBuilder.Entity<CarMod>()
            .HasKey(cm => new { cm.CarModId,cm.CarOptionId, cm.CarId } );
        // CarMod and CarOption relationship
        modelBuilder.Entity<CarMod>()
            .HasOne(cm => cm.CarOption)
            .WithMany(co => co.CarMods)
            .HasForeignKey(cm => cm.CarOptionId);

        // CarMod and Car relationship
        modelBuilder.Entity<CarMod>()
            .HasOne(cm => cm.Car)
            .WithMany(c => c.CarMods)
            .HasForeignKey(cm => cm.CarId);

        // CarOption and Car relationship
        modelBuilder.Entity<CarOption>()
            .HasKey(co => new { co.CarOptionId, co.CarId }); 
        modelBuilder.Entity<CarOption>()
            .HasOne(co => co.Car)
            .WithMany(c => c.CarOptions)
            .HasForeignKey(co => co.CarId);

        // Favorite and Car relationship
        modelBuilder.Entity<Favorite>()
            .HasKey(f => new { f.FavoriteId, f.CarId });
        modelBuilder.Entity<Favorite>()
            .HasOne(f => f.Car)
            .WithMany(c => c.Favorites)
            .HasForeignKey(f => f.CarId);


        // Order and Car relationship
        modelBuilder.Entity<Order>()
            .HasKey( o => new {o.OrderId, o.CarId});
        modelBuilder.Entity<Order>()
            .HasOne(o => o.Car)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CarId);

        


    }
}
