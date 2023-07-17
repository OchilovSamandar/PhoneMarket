using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneMarket.Dto;
using PhoneMarket.Service.IServices;

namespace PhoneMarket.Controllers
{
    [Route("api/permission")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [HttpPost]
        public IActionResult SavePermission(PermissionDto permissionDto)
        {
            ApiResponse apiResponse = _permissionService.AddPermission(permissionDto);

            if(apiResponse.Success==false)
            {
                return BadRequest(apiResponse.Message);
            }

            return Ok(apiResponse);
        }
    }
}
