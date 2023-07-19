using PhoneMarket.Model;

namespace PhoneMarket.Repository.IRepo
{
    public interface IPhoneRepo
    {
        bool AddPhone(Phone phone);
        List<Phone> GetAllPhones();
        IQueryable GetPhoneById(int id);
        bool DeletePhone(int id);

    }
}
