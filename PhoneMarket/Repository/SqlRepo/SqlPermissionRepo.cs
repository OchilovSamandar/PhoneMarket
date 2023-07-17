using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneMarket.Data;
using PhoneMarket.Model;
using PhoneMarket.Repository.IRepo;

namespace PhoneMarket.Repository.SqlRepo
{
    public class SqlPermissionRepo : IPermissionRepo
    {
        private readonly DataContext _context;
        public SqlPermissionRepo(DataContext context)
        {
            _context = context;
        }
        public async Task CreatePermission(Permission permission)
        {
            try
            {
                await _context.Permissions.AddAsync(permission);
                await _context.SaveChangesAsync();
            } catch(Exception ex) {
            
                  await Task.FromException(ex);
            }
             await Task.CompletedTask;
        }

        public  Task DeletePermission(Permission permission)
        {
            try
            {
                 _context.Permissions.Remove(permission);
                _context.SaveChangesAsync();
            }catch(Exception ex)
            {
                return Task.FromException(ex);
            }
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<Permission>> GetAllPermissions()
        {
            try
            {
              return await _context.Permissions.ToListAsync(); 
            }catch(Exception ex)
            {
                return new List<Permission>();
            }

        }

        public async Task<Permission> GetPermissionById(int id)
        {
                return await _context.Permissions.
                       FirstOrDefaultAsync(permission => permission.Id == id);         
        }

        public async Task<Permission> GetPermissionByName(string name)
        {
            return await _context.Permissions.FirstOrDefaultAsync(permission => permission.Name == name);
        }

        public Task UpdatePermission(Permission permission)
        {
            return _context.SaveChangesAsync();
        }
    }
}
