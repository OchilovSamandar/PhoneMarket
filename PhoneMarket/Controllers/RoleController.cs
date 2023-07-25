using Microsoft.AspNetCore.Mvc;
using PhoneMarket.Dto;
using PhoneMarket.Service.IServices;

namespace PhoneMarket.Controllers
{
    [Route("api/role")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        public IActionResult AddRole(RoleDto roleDto)
        {
            ApiResponse apiResponse = _roleService.AddRole(roleDto);
            if (apiResponse.Success == false)
            {
                return BadRequest(apiResponse.Message);
            }

            return Ok(apiResponse);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            ApiResponse apiResponse = _roleService.GetRoleById(id);
            if (apiResponse.Success == false)
            {
                return BadRequest(apiResponse.Message);
            }
            return Ok(apiResponse);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRole(int id)
        {
            ApiResponse apiResponse = _roleService.DeleteRole(id);
            if (apiResponse.Success == false)
            {
                return BadRequest(apiResponse.Message);
            }

            return Ok(apiResponse);
        }

        [HttpGet]
        public IActionResult GetAllRoles()
        {
            ApiResponse apiResponse = _roleService.GetAllRole();

            return Ok(apiResponse);
        }

    }
}
