namespace elitecars_admin.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int CarId { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
