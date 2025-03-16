namespace elitecars_admin.Models
{
    public class Favorite
    {
        public int FavoriteId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }

        // Navigation properties
        public Car Car { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
    }
}
