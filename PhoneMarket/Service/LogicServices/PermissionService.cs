using PhoneMarket.Dto;
using PhoneMarket.Model;
using PhoneMarket.Repository.IRepo;
using PhoneMarket.Service.IServices;

namespace PhoneMarket.Service.LogicServices
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepo _permissionRepo;

        public PermissionService(IPermissionRepo permissionRepo)
        {
            _permissionRepo = permissionRepo;
        }

        public ApiResponse AddPermission(PermissionDto permissionDto)
        {
            if (permissionDto != null)
            {
                Permission permission = new Permission();
                permission.Name = permissionDto.Name;
                permission.Description = permissionDto.Description;

                _permissionRepo.CreatePermission(permission);
                return new ApiResponse("Saqlandi", true);
            }
            return new ApiResponse("permission nul keldi", false);            
           
        }

       
        public ApiResponse DeletePermission(int id)
        {
           if(id != null)
            {
                bool v = _permissionRepo.DeletePermission(id);

                if (v=true)
                {
                    return new ApiResponse("O'chirildi", true);
                }
                return new ApiResponse("Bunday permission mavjud emas", false);

            }
            return new ApiResponse("O'chirilmadi", false);
        }


        public List<Permission> GetAllPermission()
        {
            List<Permission> permissions = _permissionRepo.GetAllPermissions();
            return permissions;

        }

        public ApiResponse GetPermissionByName(string permissionName)
        {
            if(permissionName != null)
            {
                IQueryable queryable = _permissionRepo.GetPermissionByName(permissionName);
                return new ApiResponse("topildi", true,queryable);
            }
            return new ApiResponse("topilmadi", false);
        }

        public ApiResponse GetPermissonById(int id)
        {
           if(id != null)
            {
                IQueryable queryable = _permissionRepo.GetPermissionById(id);
                
                return new ApiResponse("ok", true, queryable);
            }
            return new ApiResponse("id null keldi", false);
        }

        public ApiResponse UpdatePermission(Permission permission)
        {
            throw new NotImplementedException();
        }
    }
}
