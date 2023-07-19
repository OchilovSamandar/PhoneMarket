using PhoneMarket.Model;

namespace PhoneMarket.Repository.IRepo
{
    public interface IAuthRepo
    {
        bool Register(User user);
        
    }
}
