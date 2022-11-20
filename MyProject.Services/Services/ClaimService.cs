using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Services
{
    class ClaimService : IClaimService
    {
        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;
        public ClaimService(IClaimRepository claimRepository,IMapper mapper)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
        }

        public ClaimDTO Add(int id, int rId, int pId, Policy policy)
        {
            throw new NotImplementedException();
        }

        //public ClaimDTO Add(int id, int rId, int pId, Policy policy)
        //{
        //    return _mapper.Map<ClaimDTO>(_claimRepository.Add(id, rId, pId, policy));
        //}

        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }

        public List<ClaimDTO> GetAll()
        {
            return _mapper.Map<List<ClaimDTO>>(_claimRepository.GetAll());
        }

        public ClaimDTO GetById(int climId)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.GetById(climId));
        }

        public ClaimDTO Update(ClaimDTO claimDTO)
        {
            var claim = _claimRepository.GetById(claimDTO.Id);
            return _mapper.Map<ClaimDTO>(_claimRepository.Update(claim));
        }
    }
}
