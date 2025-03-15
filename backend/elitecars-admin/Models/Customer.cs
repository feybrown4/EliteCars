namespace elitecars_admin.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; } = string.Empty;
        public string CustomerLastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public ICollection<Favorite> Favorites { get; set; } 
        public ICollection<Cart> Carts { get; set; } 
        public ICollection<Order> Orders { get; set; } 

    }
}
