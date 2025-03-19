namespace elitecars_admin.Models
{
    public class CarOption
    {
        public int CarOptionId { get; set; }
        // public int CarId { get; set; }
        public string OptionName { get; set; } = null!;

        // Navigation properties
        public ICollection<CarOptionMod> CarOptionMods { get; set; } = null!;
        // public Car Car { get; set; } = null!;
        // public ICollection<CarMod> CarMods { get; set; } = null!;
    }
}
