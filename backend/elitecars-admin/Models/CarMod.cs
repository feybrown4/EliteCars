namespace elitecars_admin.Models
{
    public class CarMod
    {
        public int CarModId { get; set; }
        public int CarOptionId { get; set; }
        public int CarId { get; set; }
        public string ModificationName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public CarOption CarOption { get; set; }
        public Car Car { get; set; }
    }
}
