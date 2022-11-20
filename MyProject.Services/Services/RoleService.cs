using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Services
{
    class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public RoleService(IRoleRepository roleRepository,IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public RolleDTO Add(int id, string name)
        {
            return _mapper.Map<RolleDTO>( _roleRepository.Add(id, name));
        }

        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }

        public List<RolleDTO> GetAll()
        {
            return _mapper.Map<List<RolleDTO>>(_roleRepository.GetAll());
        }

        public RolleDTO GetById(int id)
        {
            return _mapper.Map<RolleDTO>(_roleRepository.GetById(id));
        }

        public RolleDTO Update(RolleDTO roleDTO)
        {
            var role = _roleRepository.GetById(roleDTO.Id);
            return _mapper.Map<RolleDTO>(_roleRepository.Update(role));
        }
    }
}
