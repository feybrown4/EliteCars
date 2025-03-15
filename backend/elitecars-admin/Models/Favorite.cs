namespace elitecars_admin.Models
{
    public class Favorite
    {
        public required int FavoriteId { get; set; }
        public required int CarId { get; set; }   
        public required int CustomerId { get; set; }

        public required Car Car { get; set; }
        public required Customer Customer { get; set; }
    }
}
