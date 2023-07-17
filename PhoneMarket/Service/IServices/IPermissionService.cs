using PhoneMarket.Dto;
using PhoneMarket.Model;

namespace PhoneMarket.Service.IServices
{
    public interface IPermissionService
    {
        ApiResponse AddPermission(PermissionDto permissionDto);
        ApiResponse DeletePermission(Permission permission);
        ApiResponse UpdatePermission(Permission permission);
        ApiResponse GetPermissonById(int id);
        ApiResponse GetPermissionByName(string permissionName);
        ApiResponse GetAllPermission();
    }
}
