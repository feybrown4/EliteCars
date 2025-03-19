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
    public DbSet<OrderItem> OrderItems { get; set; } = null!;
    public DbSet<RolePermission> RolePermissions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //RolePermission begins here
        modelBuilder
            .Entity<RolePermission>()
            .HasKey(rp => new
            {
                rp.RolePermissionId,
                rp.RoleId,
                rp.PermissionId,
            });

        modelBuilder
            .Entity<RolePermission>()
            .HasOne(rp => rp.Role)
            .WithMany(r => r.RolePermissions)
            .HasPrincipalKey(rp => rp.RoleId);

        modelBuilder
            .Entity<RolePermission>()
            .HasOne(rp => rp.Permission)
            .WithMany(p => p.RolePermissions)
            .HasPrincipalKey(rp => rp.PermissionId);
        //RolePermission ends here

        //Admin begins here
        modelBuilder.Entity<Admin>().HasKey(a => new { a.AdminId, a.RoleId });
        modelBuilder
            .Entity<Admin>()
            .HasOne(a => a.Role)
            .WithMany(r => r.Admin)
            .HasForeignKey(a => a.RoleId);
        //Admin ends here

        // CarOptionMod begins here
        modelBuilder
            .Entity<CarOptionMod>()
            .HasKey(om => new
            {
                om.CarOptionModId,
                om.CarOptionId,
                om.CarModId,
            });

        modelBuilder
            .Entity<CarOptionMod>()
            .HasOne(om => om.CarOption)
            .WithMany(co => co.CarOptionMods)
            .HasPrincipalKey(om => om.CarOptionId);

        modelBuilder
            .Entity<CarOptionMod>()
            .HasOne(om => om.CarMod)
            .WithMany(cm => cm.CarOptionMods)
            .HasPrincipalKey(om => om.CarModId);
        // CarOptionMod ends here


        //Favorite Builder begins
        modelBuilder
            .Entity<Favorite>()
            .HasKey(f => new
            {
                f.FavoriteId,
                f.CarId,
                f.CustomerId,
            });
        modelBuilder
            .Entity<Favorite>()
            .HasOne(f => f.Car)
            .WithMany(c => c.Favorites)
            .HasPrincipalKey(f => f.CarId);

        modelBuilder
            .Entity<Favorite>()
            .HasOne(f => f.Customer)
            .WithMany(cs => cs.Favorites)
            .HasPrincipalKey(f => f.CustomerId);
        //Favorite Builder ends


        //Cart builder begins
        modelBuilder
            .Entity<Cart>()
            .HasKey(ct => new
            {
                ct.CartId,
                ct.CarId,
                ct.CustomerId,
            });
        modelBuilder
            .Entity<Cart>()
            .HasOne(ct => ct.Cars)
            .WithMany(c => c.Carts)
            .HasPrincipalKey(ct => ct.CarId);

        modelBuilder
            .Entity<Cart>()
            .HasOne(ct => ct.Customers)
            .WithMany(cs => cs.Carts)
            .HasPrincipalKey(ct => ct.CustomerId);
        //Cart builder ends

        //Order Builder begins
        modelBuilder.Entity<Order>().HasKey(o => new { o.OrderId, o.CustomerId });
        modelBuilder
            .Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(cu => cu.Orders)
            .HasForeignKey(o => o.CustomerId);
        //Order Builder ends


        //orderitme begins
        modelBuilder
            .Entity<OrderItem>()
            .HasKey(ot => new
            {
                ot.OrderItemId,
                ot.OrderId,
                ot.CarId,
            });
        modelBuilder
            .Entity<OrderItem>()
            .HasOne(ot => ot.Car)
            .WithMany(c => c.OrderItems)
            .HasPrincipalKey(ot => ot.CarId);

        modelBuilder
            .Entity<OrderItem>()
            .HasOne(ot => ot.Orders)
            .WithMany(o => o.OrderItems)
            .HasPrincipalKey(ot => ot.OrderId);

        //orderitme ends

        //Car  Builder begins
        modelBuilder
            .Entity<Car>()
            .HasKey(c => new
            {
                c.CarId,
                c.AdminId,
                c.InventoryId,
            });
        modelBuilder
            .Entity<Car>()
            .HasOne(c => c.Inventory)
            .WithMany(i => i.Cars)
            .HasPrincipalKey(c => c.InventoryId);

        modelBuilder
            .Entity<Car>()
            .HasOne(c => c.Admin)
            .WithMany(a => a.Cars)
            .HasPrincipalKey(a => a.AdminId);
        //Car  Builder ends
    }
}
