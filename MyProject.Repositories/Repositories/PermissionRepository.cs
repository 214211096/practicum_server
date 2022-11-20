using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IContext _context;
        public PermissionRepository(IContext context)
        {
            _context = context;
        }
        public Permission Add(int id, string name)
        {
            Permission p = new Permission() { Id = id, Name = name };
            _context.Permissions.Add(p);
            return p;
        }

        public void Delete(int id)
        {
            Permission p = GetById(id);
            _context.Permissions.Remove(p);
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }
        public Permission GetById(int id)
        {
            for (int i = 0; i < _context.Permissions.Count; i++)
            {
                if (_context.Permissions[i].Id == id)
                    return _context.Permissions[i];
            }
            return null;
        }
        public Permission Update(Permission permission)
        {
            Permission p = GetById(permission.Id);
            p.Name = permission.Name;
            return p;
        }
    }
}
