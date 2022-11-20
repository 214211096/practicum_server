using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        List<Claim> GetAll();
        Claim GetById(int climId);
        Claim Add(int id, int rId, int pId, Policy policy);
        Claim Update(Claim claim);
        void Delete(int id);


    }
}
