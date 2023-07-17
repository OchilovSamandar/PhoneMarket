using PhoneMarket.Model;

namespace PhoneMarket.Repository.IRepo
{
    public interface IPermissionRepo
    {
        Task CreatePermission(Permission permission);
        Task DeletePermission(Permission permission);
        Task UpdatePermission(Permission permission);
        Task<Permission> GetPermissionById(int id);
        Task<Permission> GetPermissionByName(string name);
        Task<IEnumerable<Permission>> GetAllPermissions();
    }
}
