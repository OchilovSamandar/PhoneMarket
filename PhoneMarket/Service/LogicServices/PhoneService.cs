using PhoneMarket.Dto;
using PhoneMarket.Model;
using PhoneMarket.Repository.IRepo;
using PhoneMarket.Service.IServices;

namespace PhoneMarket.Service.LogicServices
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepo _phoneRepo;

        public PhoneService(IPhoneRepo phoneRepo)
        {
            _phoneRepo = phoneRepo;
        }

        public ApiResponse AddPhone(PhoneDto phoneDto)
        {
            if (phoneDto != null)
            {
                Phone phone = new Phone();
                phone.Name = phoneDto.Name;
                phone.Model = phoneDto.Model;
                phone.Description = phoneDto.Description;
                phone.Price = phoneDto.Price;
                phone.isNew = phoneDto.isNew;

                bool v = _phoneRepo.AddPhone(phone);
                if (v == true)
                {
                    return new ApiResponse("Saqlandi", true);
                }
                else
                {
                    return new ApiResponse("Saqlanmadi", false);
                }
            }
            return new ApiResponse("Phone null keldi", false);
        }

        public ApiResponse DeletePhone(int id)
        {
            if (id != 0)
            {
                bool v = _phoneRepo.DeletePhone(id);
                if (v == true)
                {
                    return new ApiResponse("O'chirildi", true);
                }
                else
                {
                    return new ApiResponse("Bunday phone topilmadi", false);
                }
            }
            return new ApiResponse("id null keldi", false);
        }

        public ApiResponse GetAllPhones()
        {
            List<Phone> phones = _phoneRepo.GetAllPhones();
            return new ApiResponse("All phones", true, phones);
        }

        public ApiResponse GetById(int id)
        {
            IQueryable queryable = _phoneRepo.GetPhoneById(id);
            return new ApiResponse("Phone", true, queryable);
        }
    }
}
