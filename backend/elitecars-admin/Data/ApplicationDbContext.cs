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


        // Composite Primary Key for RolePermission
        modelBuilder.Entity<RolePermission>()
            .HasKey(rp => new { rp.RolePermissionId, rp.RoleId, rp.PermissionId });

        modelBuilder.Entity<RolePermission>()
            .HasOne(rp => rp.Role)
            .WithMany(r => r.RolePermissions)
            .HasForeignKey(rp => rp.RoleId);

        modelBuilder.Entity<RolePermission>()
            .HasOne(rp => rp.Permission)
            .WithMany(p => p.RolePermissions)
            .HasForeignKey(rp => rp.PermissionId);


        //Admin to role
        modelBuilder.Entity<Admin>()
            .HasKey(a => new { a.AdminId, a.RoleId });
        modelBuilder.Entity<Admin>()
            .HasOne(a => a.Role)
            .WithMany(r => r.Admin)
            .HasForeignKey(a => a.RoleId);

        //CarMod Builder begins
        modelBuilder.Entity<CarMod>()
            .HasKey(cm => new { cm.CarModId,cm.CarOptionId, cm.CarId } );
       
        modelBuilder.Entity<CarMod>()
            .HasOne(cm => cm.CarOption)
            .WithMany(co => co.CarMods)
            .HasForeignKey(cm => cm.CarOptionId);

        modelBuilder.Entity<CarMod>()
            .HasOne(cm => cm.Car)
            .WithMany(c => c.CarMods)
            .HasForeignKey(cm => cm.CarId);
        //CarMod Builder ends

        //CarOption Builder begins
        modelBuilder.Entity<CarOption>()
            .HasKey(co => new { co.CarOptionId, co.CarId });
        modelBuilder.Entity<CarOption>()
            .HasOne(co => co.Car)
            .WithMany(c => c.CarOptions)
            .HasForeignKey(co => co.CarId);
        //CarOption Builder ends


        //Favorite Builder begins
        modelBuilder.Entity<Favorite>()
            .HasKey(f => new { f.FavoriteId, f.CarId,f.CustomerId });
        modelBuilder.Entity<Favorite>()
            .HasOne(f => f.Car)
            .WithMany(c => c.Favorites)
            .HasForeignKey(f => f.CarId);

        modelBuilder.Entity<Favorite>()
            .HasOne(f => f.Customer)
            .WithMany(cs => cs.Favorites)
            .HasForeignKey(f => f.CustomerId);
        //Favorite Builder ends


        //Cart builder begins
        modelBuilder.Entity<Cart>()
            .HasKey(ct => new { ct.CartId, ct.CarId, ct.CustomerId });
        modelBuilder.Entity<Cart>()
            .HasOne(ct => ct.Cars)
            .WithMany(c => c.Carts)
            .HasForeignKey(ct => ct.CarId);

        modelBuilder.Entity<Cart>()
            .HasOne(ct => ct.Customers)
            .WithMany(cs => cs.Carts)
            .HasForeignKey(ct => ct.CustomerId);

        //Order Builder begins
        modelBuilder.Entity<Order>()
            .HasKey( o => new {o.OrderId, o.CustomerId});
        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(cu => cu.Orders)
            .HasForeignKey(o => o.CustomerId);
        //Order Builder ends


        //orderitme begins
        modelBuilder.Entity<OrderItem>()
            .HasKey ( ot => new {ot.OrderItemId, ot.OrderId, ot.CarId});
        modelBuilder.Entity<OrderItem>()
            .HasOne(ot => ot.Car)
            .WithMany(c => c.OrderItems)
            .HasForeignKey(ot => ot.OrderItemId);

        modelBuilder.Entity<OrderItem>()
            .HasOne(ot => ot.Orders)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(ot => ot.OrderId);

        //Car  Builder begins
        modelBuilder.Entity<Car>()
            .HasKey(c => new  { c.CarId, c.AdminId, c.InventoryId });
        modelBuilder.Entity<Car>()
           .HasOne(c => c.Inventory)
           .WithMany(i => i.Cars)
           .HasForeignKey(c => c.InventoryId);

        modelBuilder.Entity<Car>()
            .HasOne(c => c.Admin)
            .WithMany(a => a.Cars)
            .HasForeignKey(c => c.AdminId);
        //Car  Builder ends

    }
}
