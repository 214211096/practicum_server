using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Services
{
    class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;
        public PermissionService(IPermissionRepository permissionRepository,IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }
        public PermissionDTO Add(int id, string name)
        {
            return _mapper.Map<PermissionDTO>(_permissionRepository.Add(id, name));
        }

        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }

        public List<PermissionDTO> GetAll()
        {
            return _mapper.Map<List<PermissionDTO>>(_permissionRepository.GetAll());
        }

        public PermissionDTO GetById(int id)
        {
           return _mapper.Map<PermissionDTO>(_permissionRepository.GetById(id));
        }

        public PermissionDTO Update(PermissionDTO permissionDTO)
        {
            var per = _permissionRepository.GetById(permissionDTO.Id);
            return _mapper.Map<PermissionDTO>(_permissionRepository.Update(per));
        }
    }
}
