using Bogus;
using elitecars_admin.Models;
using Microsoft.EntityFrameworkCore;


namespace elitecars_admin.Data
{
    public class DbSeeder
    {

        public static void Seed(ApplicationDbContext context)
        {

            

            var roleFaker = new Faker<Role>()
                .RuleFor(r => r.RoleName, f => f.Name.JobTitle());

            var permissionFaker = new Faker<Permission>()
                .RuleFor(p => p.PermissionName, f => f.Lorem.Word());

            context.Roles.AddRange(roleFaker);
            context.Permissions.AddRange(permissionFaker);
            context.SaveChanges();


            // Fetch IDs
            var roleIds = context.Roles.Select(r => r.RoleId).ToList();
            var permissionIds = context.Permissions.Select(p => p.PermissionId).ToList();

            var rolePermissionFaker = new Faker<RolePermission>()
                 .RuleFor(rp => rp.RoleId, f => f.PickRandom(roleIds))
                 .RuleFor(rp => rp.PermissionId, f => f.PickRandom(permissionIds));

            var rolePermissions = rolePermissionFaker.Generate(10);
            context.RolePermissions.AddRange(rolePermissions);
            context.SaveChanges();

            /*      var adminFaker = new Faker<Admin>()
                      .RuleFor(a => a.AdminId, f => f.IndexFaker + 1)
                      .RuleFor(a => a.FirstName, f => f.Name.FirstName())
                      .RuleFor(a => a.LastName, f => f.Name.LastName())
                      .RuleFor(a => a.Email, f => f.Internet.Email())
                      .RuleFor(a => a.Password, f => f.Internet.Password())
                      .RuleFor(a => a.RoleId, f => f.Random.Int(1, 5));

                  var customerFaker = new Faker<Customer>()
                      .RuleFor(c => c.CustomerId, f => f.IndexFaker + 1)
                      .RuleFor(c => c.CustomerFirstName, f => f.Name.FirstName())
                      .RuleFor(c => c.CustomerLastName, f => f.Name.LastName())
                      .RuleFor(c => c.Address, f => f.Address.FullAddress())
                      .RuleFor(c => c.Email, f => f.Internet.Email())
                      .RuleFor(c => c.Password, f => f.Internet.Password());

                  var inventoryFaker = new Faker<Inventory>()
                      .RuleFor(i => i.InventoryId, f => f.IndexFaker + 1)
                      .RuleFor(i => i.DateAdded, f => f.Date.Past(1));

                  var carFaker = new Faker<Car>()
                      .RuleFor(c => c.CarId, f => f.IndexFaker + 1)
                      .RuleFor(c => c.Name, f => f.Vehicle.Model())
                      .RuleFor(c => c.IsActive, f => f.Random.Bool())
                      .RuleFor(c => c.IsModify, f => f.Random.Bool())
                      .RuleFor(c => c.CarType, f => f.Vehicle.Type())
                      .RuleFor(c => c.Quantity, f => f.Random.Int(1, 10))
                      .RuleFor(c => c.Model, f => f.Vehicle.Model())
                      .RuleFor(c => c.Year, f => f.Date.Past(10).Year)
                      .RuleFor(c => c.Price, f => f.Random.Decimal(10000, 50000))
                      .RuleFor(c => c.Image, f => f.Image.PicsumUrl())
                      .RuleFor(c => c.Description, f => f.Lorem.Paragraph())
                      .RuleFor(c => c.CreatedAt, f => f.Date.Past(2))
                      .RuleFor(c => c.AdminId, f => f.Random.Int(1, 5))
                      .RuleFor(c => c.InventoryId, f => f.Random.Int(1, 5));

                  var orderFaker = new Faker<Order>()
                      .RuleFor(o => o.OrderId, f => f.IndexFaker + 1)
                      .RuleFor(o => o.CarId, f => f.Random.Int(1, 15))
                      .RuleFor(o => o.CustomerId, f => f.Random.Int(1, 15))
                      .RuleFor(o => o.Status, f => OrderStatus.Pending)
                      .RuleFor(o => o.Address, f => f.Address.FullAddress())
                      .RuleFor(o => o.OrderDate, f => f.Date.Past(1))
                      .RuleFor(o => o.DeliveryDate, f => f.Date.Future(1))
                      .RuleFor(o => o.IsPickup, f => f.Random.Bool());

                  var favoriteFaker = new Faker<Favorite>()
                      .RuleFor(f => f.FavoriteId, f => f.IndexFaker + 1)
                      .RuleFor(f => f.CarId, f => f.Random.Int(1, 15))
                      .RuleFor(f => f.CustomerId, f => f.Random.Int(1, 15));

                  var cartFaker = new Faker<Cart>()
                      .RuleFor(ct => ct.CartId, f => f.IndexFaker + 1)
                      .RuleFor(ct => ct.CarId, f => f.Random.Int(1, 15))
                      .RuleFor(ct => ct.CustomerId, f => f.Random.Int(1, 15))
                      .RuleFor(ct => ct.Quantity, f => f.Random.Int(1, 5).ToString());

                  var carModFaker = new Faker<CarMod>()
                      .RuleFor(cm => cm.CarModId, f => f.IndexFaker + 1)
                      .RuleFor(cm => cm.ModificationName, f => f.Commerce.ProductName())
                      .RuleFor(cm => cm.Amount, f => f.Random.Decimal(100, 1000));

                  var carOptionFaker = new Faker<CarOption>()
                      .RuleFor(co => co.CarOptionId, f => f.IndexFaker + 1)
                      .RuleFor(co => co.OptionName, f => f.Commerce.ProductName());

                  var carOptionModFaker = new Faker<CarOptionMod>()
                      .RuleFor(com => com.CarOptionModId, f => f.IndexFaker + 1)
                      .RuleFor(com => com.CarOptionId, f => f.Random.Int(1, 15))
                      .RuleFor(com => com.CarModId, f => f.Random.Int(1, 15));

                  var orderItemFaker = new Faker<OrderItem>()
                      .RuleFor(oi => oi.OrderItemId, f => f.IndexFaker + 1)
                      .RuleFor(oi => oi.OrderId, f => f.Random.Int(1, 15))
                      .RuleFor(oi => oi.CarId, f => f.Random.Int(1, 15))
                      .RuleFor(oi => oi.Quantity, f => f.Random.Int(1, 5).ToString())
                      .RuleFor(oi => oi.PurchasePrice, f => f.Random.Decimal(1000, 10000));
            */


            // Generate fake data
            /*var roles = roleFaker.Generate(5);
            var permissions = permissionFaker.Generate(5);
            var rolePermissions = rolePermissionFaker.Generate(10);
            var admins = adminFaker.Generate(5);
            var customers = customerFaker.Generate(10);
            var inventories = inventoryFaker.Generate(5);
            var cars = carFaker.Generate(15);
            var orders = orderFaker.Generate(10);
            var favorites = favoriteFaker.Generate(10);
            var carts = cartFaker.Generate(10);
            var carMods = carModFaker.Generate(15);
            var carOption = carOptionFaker.Generate(15);
            var carOptionMod = carOptionModFaker.Generate(15);
            var orderItem = orderItemFaker.Generate(15);*/

            // Add to the context
            /*context.Roles.AddRange(roles);
            context.Permissions.AddRange(permissions);
            context.RolePermissions.AddRange(rolePermissions);
           context.Admin.AddRange(admins);
            context.Customers.AddRange(customers);
            context.Inventories.AddRange(inventories);
            context.Cars.AddRange(cars);
            context.Orders.AddRange(orders);
            context.Favorites.AddRange(favorites);
            context.Carts.AddRange(carts);
            context.CarMods.AddRange(carMods);
            context.CarOptions.AddRange(carOption);
            context.CarOptionMods.AddRange(carOptionMod);
            context.OrderItems.AddRange(orderItem);*/

            // Save to the database
            //context.SaveChanges();
        }
    }
}
