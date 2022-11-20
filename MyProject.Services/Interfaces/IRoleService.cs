using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Interfaces
{
    interface IRoleService
    {
        List<RolleDTO> GetAll();

        RolleDTO GetById(int id);

        RolleDTO Add(int id, string name);

        RolleDTO Update(RolleDTO role);

        void Delete(int id);
    }
}
