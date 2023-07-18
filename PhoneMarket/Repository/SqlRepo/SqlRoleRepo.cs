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

        public bool GetRoleById(int id)
        {
            bool result = false;
            try
            {////////////////////////////////////////////////getRoleId methodi yozilyotgandi
             ////////////////////////////////////////////////va role service methodlarida ham togirlash kerak
                 _context.Roles.Where(x => x.Id == id);
                result = true;
            }catch(Exception e) { result=false; }

            return result;

        }

        public Role GetRoleByName(string RoleName)
        {
            throw new NotImplementedException();
        }
    }
}
