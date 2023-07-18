using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneMarket.Dto;
using PhoneMarket.Service.IServices;

namespace PhoneMarket.Controllers
{
    [Route("api/phone")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IPhoneService _phoneService;

        public PhoneController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        [HttpPost]
        public IActionResult PhoneSave(PhoneDto phoneDto)
        {
            ApiResponse apiResponse = _phoneService.AddPhone(phoneDto);
            if(apiResponse.Success==false)
            {
                return BadRequest(apiResponse.Message);
            }
            return Ok(apiResponse);
        }

        [HttpGet]
        public IActionResult GetAllPhones()
        {
            ApiResponse apiResponse = _phoneService.GetAllPhones();
            return Ok(apiResponse);
        }
        [HttpGet("{id}")]
        public IActionResult GetPhone(int id)
        {
            ApiResponse apiResponse = _phoneService.GetById(id);
            return Ok(apiResponse);
        }
    }
}
