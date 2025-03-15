namespace elitecars_admin.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string Quantity { get; set; } = string.Empty;
        public Car Car { get; set; }
        public Customer Customer { get; set; }

    }
}
