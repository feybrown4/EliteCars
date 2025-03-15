namespace elitecars_admin.Models
{
    public class Cart
    {
        public required int CartId { get; set; }
        public required int CarId { get; set; }
        public required int CustomerId { get; set; }
        public required string Quantity { get; set; }
        public required Car Cars { get; set; } 
        public required Customer Customers { get; set; } 

    }
}
