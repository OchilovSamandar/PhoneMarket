using PhoneMarket.Dto;

namespace PhoneMarket.Service.IServices
{
    public interface IRoleService
    {
        ApiResponse AddRole(RoleDto roleDto);
        ApiResponse DeleteRole(int id);
        ApiResponse GetRoleById(int id);
        ApiResponse GetRoleByName(string roleName);
        ApiResponse UpdateRole(RoleDto roleDto);
        ApiResponse GetAllRole();

    }
}
