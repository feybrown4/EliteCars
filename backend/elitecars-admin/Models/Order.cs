namespace elitecars_admin.Models
{
    public enum OrderStatus
    {
        Pending,
        Confirmed,
        Delivered,
        Closed,
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public string Address { get; set; } = null!;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public bool IsPickup { get; set; } // New property to indicate pickup or delivery

        // Navigation properties
        // public Car Car { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
    }
}
