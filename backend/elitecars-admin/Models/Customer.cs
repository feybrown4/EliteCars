using System.Security.Cryptography.Xml;

namespace elitecars_admin.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; } = null!;
        public string CustomerLastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        // Navigation Properties
        public ICollection<Favorite> Favorites { get; set; } = null!;
        public ICollection<Cart> Carts { get; set; } = null!;
        public ICollection<Order> Orders { get; set; } = null!;
    }
}
