﻿namespace elitecars_admin.Models
{
    public class Inventory
    {
        public required int InventoryId { get; set; }
        public required int CarId { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public required ICollection<Car> Cars { get; set; } = [];

    }
}
