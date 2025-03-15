using System.Text.Json.Serialization;

namespace elitecars_admin.Models;

public class Car(
    int CarId,
    string Name,
    bool IsActive,
    bool IsModify,
    string CarType,
    int Quantity,
    string Model,
    int Year,
    decimal Price,
    string Image,
    string Description
// Admin admin_id,
)
{
    [JsonPropertyName("car_id")]
    public int CarId { get; set; } = CarId;

    public string Name { get; set; } = Name;

    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; } = IsActive;

    [JsonPropertyName("is_modify")]
    public bool IsModify { get; set; } = IsModify;

    [JsonPropertyName("car_type")]
    public string CarType { get; set; } = CarType;

    public int Quantity { get; set; } = Quantity;

    public string Model { get; set; } = Model;

    public int Year { get; set; } = Year;

    public decimal Price { get; set; } = Price;

    public string Image { get; set; } = Image;

    public string Description { get; set; } = Description;

    // public Admin Admin_Id { get; set; } = null!;

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public Admin Admin { get; set; }
    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Cart> Carts { get; set; } 
    public ICollection<Order> Orders { get; set; } 
    public ICollection<CarOption> CarOptions { get; set; } 
    public ICollection<Inventory> Inventories { get; set; } 
}
