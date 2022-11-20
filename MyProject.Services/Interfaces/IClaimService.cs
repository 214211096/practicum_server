using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Interfaces
{
    public interface IClaimService
    {
        List<ClaimDTO> GetAll();
        ClaimDTO GetById(int climId);
        ClaimDTO Add(int id, int rId, int pId, Policy policy);
        ClaimDTO Update(ClaimDTO claim);
        void Delete(int id);
    }
}
