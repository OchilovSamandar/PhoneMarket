using PhoneMarket.Model;

namespace PhoneMarket.Repository.IRepo
{
    public interface IPermissionRepo
    {
        Task CreatePermission(Permission permission);
        bool  DeletePermission(int id);
        Task UpdatePermission(Permission permission);
        IQueryable GetPermissionById(int id);
        IQueryable GetPermissionByName(string name);
        List<Permission> GetAllPermissions();
    }
}
