namespace elitecars_admin.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}
