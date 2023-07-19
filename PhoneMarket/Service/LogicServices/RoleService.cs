using PhoneMarket.Dto;
using PhoneMarket.Dto.enums;
using PhoneMarket.Model;
using PhoneMarket.Repository.IRepo;
using PhoneMarket.Service.IServices;

namespace PhoneMarket.Service.LogicServices
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepo _roleRepo;

        public RoleService(IRoleRepo roleRepo)
        {
            _roleRepo = roleRepo;
        }

        public ApiResponse AddRole(RoleDto roleDto)
        {
            if(roleDto != null)
            {
                Role role = new Role
                {
                    Name = roleDto.Name,
                    Description = roleDto.Description,
                    Permissions = roleDto.PermissionDtos.Select(p =>  new Permission
                    {
                        Name = p.Name,
                        Description = p.Description

                    }).ToList()
                };

                bool v = _roleRepo.AddRole(role);
                if (v != true)
                {
                    return new ApiResponse("Saqlanmadi", false);
                }
                return new ApiResponse("saqlandi",true);
            }
            return new ApiResponse("RoleDto null keldi", false);
        }

        public ApiResponse DeleteRole(int id)
        {
            if (id > 0)
            {
                bool v = _roleRepo.DeleteRole(id);
                if (v == true)
                {
                    return new ApiResponse("O'chirildi", true);
                }
                else
                {
                    return new ApiResponse("O'chrilmadi", false);
                }
            }
            return new ApiResponse("id null keldi", false );
        }

        public ApiResponse GetAllRole()
        {
            List<Role> roles = _roleRepo.GetAllRoles();
            return new ApiResponse("all roles",true,roles);
        }

        public ApiResponse GetRoleById(int id)
        {
            if(id != 0)
            {
                IQueryable role = _roleRepo.GetRoleById(id);
                Console.WriteLine(role.ToString());
                if (role.Equals(null))
                {

                    return new ApiResponse("Bunday role mavjud emas", false);
                }
                else
                {
                    return new ApiResponse("id", true, role);
                }
            }
            return new ApiResponse("id null keldi",false);
        }

        public ApiResponse GetRoleByName(string roleName)
        {
            throw new NotImplementedException();
        }

        public ApiResponse UpdateRole(RoleDto roleDto)
        {
            throw new NotImplementedException();
        }
    }
}
