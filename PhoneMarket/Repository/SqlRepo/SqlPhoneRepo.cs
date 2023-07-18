using PhoneMarket.Data;
using PhoneMarket.Model;
using PhoneMarket.Repository.IRepo;

namespace PhoneMarket.Repository.SqlRepo
{
    public class SqlPhoneRepo : IPhoneRepo
    {
        private readonly DataContext _context;

        public SqlPhoneRepo(DataContext context)
        {
            _context = context;
        }

        public bool AddPhone(Phone phone)
        {
           bool result = false;
            try
            {
                _context.Phones.Add(phone);
                _context.SaveChanges();
                result = true;
            }catch (Exception ex)
            {
                result= false;
            }
            return result;
        }

        public List<Phone> GetAllPhones()
        {
            List<Phone> phones = _context.Phones.ToList();
            return phones;
        }

        public IQueryable GetPhoneById(int id)
        {
            IQueryable<Phone> phones = _context.Phones.Where(x => x.Id == id);
            return phones;
        }
    }
}
