namespace elitecars_admin.Models;

public class Admin
{
    public required int AdminId { get; set; }

    public required string FirstName { get; set; } 

    public required string LastName { get; set; }

    public required string Email { get; set; } 

    public required string Password { get; set; }

    public required int RoleId { get; set; }

    public ICollection<Car> Cars { get; set; } = [];

    public required Role Role { get; set; }
}
