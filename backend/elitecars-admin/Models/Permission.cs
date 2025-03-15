namespace elitecars_admin.Models
{
    public class Permission
    {
        public required  int PermissionId { get; set; }
        public required string permission { get; set; } 
        public required RolePermission RolePermissions { get; set; }
    }
}
