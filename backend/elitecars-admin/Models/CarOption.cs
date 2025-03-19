namespace elitecars_admin.Models
{
    public class CarOption
    {
        public int CarOptionId { get; set; }
        public string OptionName { get; set; } = null!;

        // Navigation properties
        public ICollection<CarOptionMod> CarOptionMods { get; set; } = null!;
    }
}
