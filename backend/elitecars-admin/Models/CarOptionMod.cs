namespace elitecars_admin.Models
{
    public class CarOptionMod
    {
        public int CarOptionModId { get; set; }
        public int CarOptionId { get; set; }
        public string CarModId { get; set; } = null!;

        // Navigation properties
        public CarOption CarOption { get; set; } = null!;
        public CarMod CarMod { get; set; } = null!;
    }
}
