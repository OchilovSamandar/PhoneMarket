using PhoneMarket.Model;

namespace PhoneMarket.Repository.IRepo
{
    public interface IRoleRepo
    {
        bool AddRole(Role Role);
        
        Role GetRoleByName(string RoleName);
        bool GetRoleById(int id);

        bool DeleteRole(int id);

        List<Role> GetAllRoles();
    }
}
