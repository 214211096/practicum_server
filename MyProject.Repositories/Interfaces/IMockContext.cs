using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories
{
    interface IMockContext
    {
        public List <Role> Roles { get; set; }
        public List <Claim> Claims { get; set; }
        public List <Permission> Permissions { get; set; }
    }
}
