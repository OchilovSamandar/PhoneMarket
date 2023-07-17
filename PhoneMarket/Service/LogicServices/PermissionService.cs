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

        public  ApiResponse AddPermission(PermissionDto permissionDto)
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

       
        public ApiResponse DeletePermission(Permission permission)
        {
           if(permission != null)
            {
                _permissionRepo.DeletePermission(permission);
                return new ApiResponse("O'chirildi", true);
            }
            return new ApiResponse("O'chirilmadi", false);
        }


        public ApiResponse GetAllPermission()
        {
            throw new NotImplementedException();
        }

        public ApiResponse GetPermissionByName(string permissionName)
        {
            throw new NotImplementedException();
        }

        public ApiResponse GetPermissonById(int id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse UpdatePermission(Permission permission)
        {
            throw new NotImplementedException();
        }
    }
}
