using System.Security.Cryptography.Xml;

namespace elitecars_admin.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public required string CustomerFirstName { get; set; }
        public required string CustomerLastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public ICollection<Favorite> Favorites { get; set; } = [];
        public ICollection<Cart> Carts { get; set; } = [];
        public ICollection<Order> Orders { get; set; } = [];

    }
}
