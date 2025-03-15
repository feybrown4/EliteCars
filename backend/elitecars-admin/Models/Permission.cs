namespace elitecars_admin.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string permission { get; set; } = string.Empty;
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
