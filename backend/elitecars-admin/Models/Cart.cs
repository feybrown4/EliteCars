namespace elitecars_admin.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string Quantity { get; set; } = null!;

        // Navigation properties
        public Car Cars { get; set; } = null!;
        public Customer Customers { get; set; } = null!;
    }
}
