namespace elitecars_admin.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; } = null!;

        // Navigation properties
        public ICollection<RolePermission> RolePermissions { get; set; } = null!;
    }
}
