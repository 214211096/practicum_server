using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace MyProject.Repositories.Interfaces
{
    public interface IPermissionRepository
    {
        List<Permission> GetAll();

        Permission GetById(int id);

        Permission Add(int id, string name);

        Permission Update(Permission role);

        void Delete(int id);
    }
}
