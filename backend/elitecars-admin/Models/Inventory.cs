namespace elitecars_admin.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;

        // Navigation properties
        public required ICollection<Car> Cars { get; set; } = null!;
    }
}
