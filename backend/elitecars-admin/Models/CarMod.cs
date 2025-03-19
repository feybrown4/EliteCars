namespace elitecars_admin.Models
{
    public class CarMod
    {
        public int CarModId { get; set; }

        public string ModificationName { get; set; } = null!;
        public decimal Amount { get; set; }

        // Navigation properties
        public ICollection<CarOptionMod> CarOptionMods { get; set; } = null!;
    }
}
