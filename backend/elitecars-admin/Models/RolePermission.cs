namespace elitecars_admin.Models
{
    public class RolePermission
    {
        public required int RolePermissionId { get; set; }
        public required int RoleId { get; set; }
        public required int PermissionId { get; set; }

        public ICollection<Role> Roles { get; set; } = [];
        public required ICollection<Permission> Permissions { get; set; } = [];
    }
}
