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
    public required int CarId { get; set; } 

    public required string Name { get; set; } 

    [JsonPropertyName("is_active")]
    public required bool IsActive { get; set; } 

    [JsonPropertyName("is_modify")]
    public required bool IsModify { get; set; } 

    [JsonPropertyName("car_type")]
    public required string CarType { get; set; } 

    public required int Quantity { get; set; } 

    public required string Model { get; set; } 

    public required int Year { get; set; } 

    public required decimal Price { get; set; } 

    public required string Image { get; set; }

    public required string Description { get; set; } 

    public required int  AdminId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public required Admin Admin { get; set; }
    public ICollection<Favorite> Favorites { get; set; } = [];
    public ICollection<Cart> Carts { get; set; } = [];
    public ICollection<Order> Orders { get; set; } = [];
    public ICollection<CarOption> CarOptions { get; set; } = [];
    public ICollection<Inventory> Inventories { get; set; } = [];
    public  ICollection <CarMod> CarMods { get; set; } = [];
}
