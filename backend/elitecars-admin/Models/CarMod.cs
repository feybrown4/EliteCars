namespace elitecars_admin.Models
{
    public class CarMod
    {
        public int CarModId { get; set; }
        // public int CarOptionId { get; set; }
        // public int CarId { get; set; }
        public string ModificationName { get; set; } = null!;
        public decimal Amount { get; set; }

        // Navigation properties
        public ICollection<CarOptionMod> CarOptionMods { get; set; } = null!;
        // public CarOption CarOption { get; set; } = null!;
        // public Car Car { get; set; } = null!;
    }
}
