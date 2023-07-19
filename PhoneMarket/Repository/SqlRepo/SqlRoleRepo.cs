using PhoneMarket.Data;
using PhoneMarket.Model;
using PhoneMarket.Repository.IRepo;

namespace PhoneMarket.Repository.SqlRepo
{
    public class SqlRoleRepo : IRoleRepo
    {
        private readonly DataContext _context;

        public SqlRoleRepo(DataContext context)
        {
            _context = context;
        }

        public  bool AddRole(Role role)
        {
            bool result = false;
            try
            {
                _context.Roles.Add(role);
                _context.SaveChanges();
                result = true;
            }catch (Exception ex)
            {
              result=false;
            }
            return result;
        }

        public bool DeleteRole(int id)
        {
            IQueryable<Role> roles = _context.Roles.Where(x => x.Id == id);
            bool result = false;
            try
            {
                _context.Roles.Remove((Role)roles);
                _context.SaveChanges();
                result = true;
            }catch(Exception ex)
            {
                result=false;
            }
            return result;
        }

        public List<Role> GetAllRoles()
        {
            List<Role> roles = _context.Roles.ToList();
            return roles;
        }

        public IQueryable GetRoleById(int id)
        {
                IQueryable<Role> roles = _context.Roles.Where(x => x.Id == id);
            return roles;
               

        }

        public Role GetRoleByName(string RoleName)
        {
            throw new NotImplementedException();
        }
    }
}
