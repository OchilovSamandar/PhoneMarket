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

            if (apiResponse.Success == false)
            {
                return BadRequest(apiResponse.Message);
            }

            return Ok(apiResponse);
        }

        [HttpGet("/get/{id}")]
        public IActionResult GetPermission(int id)
        {
            ApiResponse apiResponse = _permissionService.GetPermissonById(id);
            if (apiResponse.Success == false)
            {
                return BadRequest(apiResponse.Message);
            }
            return Ok(apiResponse);
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            ApiResponse apiResponse = _permissionService.GetPermissionByName(name);
            if (apiResponse.Success == false)
                return BadRequest(apiResponse.Message);

            return Ok(apiResponse);
        }

        [HttpDelete]
        public IActionResult DeletePermission(int id)
        {
            ApiResponse apiResponse = _permissionService.DeletePermission(id);
            if (apiResponse.Success == false)
            {
                return NotFound();
            }
            return Ok(apiResponse);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _permissionService.GetAllPermission();

            return Ok(model);
        }
    }
}
