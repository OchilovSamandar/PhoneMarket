using PhoneMarket.Dto;
using PhoneMarket.Model;

namespace PhoneMarket.Service.IServices
{
    public interface IPermissionService
    {
        ApiResponse AddPermission(PermissionDto permissionDto);
        ApiResponse DeletePermission(int id);
        ApiResponse UpdatePermission(Permission permission);
        ApiResponse GetPermissonById(int id);
        ApiResponse GetPermissionByName(string permissionName);
        List<Permission> GetAllPermission();
    }
}
