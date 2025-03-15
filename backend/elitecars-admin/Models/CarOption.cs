namespace elitecars_admin.Models
{
    public class CarOption
    {
        public  required int CarOptionId { get; set; }
        public required int CarId { get; set; }
        public required string OptionName { get; set; } 
        public required Car Car { get; set; }
        public ICollection<CarMod> CarMods { get; set; } = [];
    }
}
