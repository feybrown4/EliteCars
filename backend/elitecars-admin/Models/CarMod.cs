namespace elitecars_admin.Models
{
    public class CarMod
    {
        public required int CarModId { get; set; }
        public required int CarOptionId { get; set; }
        public required int CarId { get; set; }
        public required string ModificationName { get; set; } 
        public required decimal Amount { get; set; }
        public required CarOption CarOption { get; set; }
        public required Car Car { get; set; }
    }
}
