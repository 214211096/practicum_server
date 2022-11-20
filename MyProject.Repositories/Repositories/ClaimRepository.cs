using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepository

    {
        private readonly IContext _context;
        public ClaimRepository(IContext context)
        {
            _context = context;
        }
        public Claim Add(int id, int rId, int pId, Policy policy)
        {
            Claim c = new Claim() { Id = id, PermissionId = pId, RoleId = rId, Policy = policy };
            _context.Claims.Add(c);
            return c;
        }

        public void Delete(int id)
        {
            Claim c = GetById(id);
            _context.Claims.Remove(c);
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int climId)
        {
            for (int i = 0; i < _context.Claims.Count; i++)
            {
                if (_context.Claims[i].Id == climId)
                    return _context.Claims[i];
            }
            return null;
        }

        public Claim Update(Claim claim)
        {
            Claim temp = GetById(claim.Id);
            temp.PermissionId = claim.PermissionId;
            temp.Policy = claim.Policy;
            temp.RoleId = claim.RoleId;
            return temp;
        }
    }
}
