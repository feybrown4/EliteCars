namespace elitecars_admin.Models;

public class Role
{
    public int RoleId { get; set; }
    public string RoleName { get; set; } = null!;

    // Navigation properties
    public ICollection<RolePermission> RolePermissions { get; set; } = null!;
    public ICollection<Admin> Admin { get; set; } = null!;
}
