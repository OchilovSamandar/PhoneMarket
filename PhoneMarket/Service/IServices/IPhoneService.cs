using PhoneMarket.Dto;

namespace PhoneMarket.Service.IServices
{
    public interface IPhoneService
    {
        ApiResponse AddPhone(PhoneDto phoneDto);
        ApiResponse GetAllPhones();
        ApiResponse GetById(int id);
    }
}
