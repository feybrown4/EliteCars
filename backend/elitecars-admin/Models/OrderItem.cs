namespace elitecars_admin.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }

        public int CarId { get; set; }

        public string Quantity { get; set; } = null!;

        public decimal PurchasePrice { get; set; }

        public Car Car { get; set; } = null!;

        public Order Orders { get; set; } = null!;
    }
}
