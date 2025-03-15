namespace elitecars_admin.Models;

public class Role
{
    public required int RoleId { get; set; }
    public required string RoleName { get; set; } 

    public required RolePermission RolePermissions { get; set; } 
    public ICollection<Admin> Admin { get; set; } = [];
}
