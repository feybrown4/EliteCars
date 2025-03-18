using System.Text.Json.Serialization;

namespace elitecars_admin.Models;

public class Car
{
    [JsonPropertyName("car_id")]
    public int CarId { get; set; }

    public string Name { get; set; } = null!;

    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    [JsonPropertyName("is_modify")]
    public bool IsModify { get; set; }

    [JsonPropertyName("car_type")]
    public string CarType { get; set; } = null!;

    public int Quantity { get; set; }

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public decimal Price { get; set; }

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public int AdminId { get; set; }

    // Navigation properties
    public Admin Admin { get; set; } = null!;
    public ICollection<Favorite> Favorites { get; set; } = null!;
    public ICollection<Cart> Carts { get; set; } = null!;
    public ICollection<Order> Orders { get; set; } = null!;
    public ICollection<CarOption> CarOptions { get; set; } = null!;
    public Inventory Inventory { get; set; } = null!;
    public ICollection<CarMod> CarMods { get; set; } = null!;
}
