using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Interfaces
{
    interface IPermissionService
    {
        List<PermissionDTO> GetAll();
        PermissionDTO GetById(int id);

        PermissionDTO Add(int id, string name);

        PermissionDTO Update(PermissionDTO role);

        void Delete(int id);
    }
}
