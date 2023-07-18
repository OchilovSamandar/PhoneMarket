using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneMarket.Data;
using PhoneMarket.Exceptions;
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

        public bool DeletePermission(int id)
        {
            Permission? permission = _context.Permissions.Find(id);
            
            bool b = false;
            try
            {
                 _context.Permissions.Remove(permission);
                  _context.SaveChangesAsync();
                b = true;
            }catch(Exception ex)
            {
                 b= false ;
            }
            return b;
        }

        public  List<Permission> GetAllPermissions()
        {
            List<Permission> permissions = _context.Permissions.ToList();
            return permissions;

        }

        public  IQueryable GetPermissionById(int id)
        {

            return  _context.Permissions.Where(x => x.Id == id);
               
        }

        public IQueryable GetPermissionByName(string name)
        {
            IQueryable<Permission> permissions = _context.Permissions.Where(permission => permission.Name == name);
            
            return permissions;
        }

        public Task UpdatePermission(Permission permission)
        {
            return _context.SaveChangesAsync();
        }
    }
}
