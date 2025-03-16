namespace elitecars_admin.Models;

public class Admin
{
    public int AdminId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    // Navigation properties
    public ICollection<Car> Cars { get; set; } = null!;

    public Role Role { get; set; } = null!;
}
