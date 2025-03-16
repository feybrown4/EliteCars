namespace elitecars_admin.Models
{
    public class RolePermission
    {
        public int RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        // Navigation properties
        public ICollection<Role> Role { get; set; } = null!;
        public ICollection<Permission> Permission { get; set; } = null!;
    }
}
