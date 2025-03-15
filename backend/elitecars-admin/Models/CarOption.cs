namespace elitecars_admin.Models
{
    public class CarOption
    {
        public int CarOptionId { get; set; }
        public int CarId { get; set; }
        public string OptionName { get; set; } = string.Empty;
        public Car Car { get; set; }
        public ICollection<CarMod> CarMods { get; set; } 
    }
}
