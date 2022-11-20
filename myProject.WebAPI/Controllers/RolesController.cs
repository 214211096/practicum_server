using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;

namespace myProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
        public RolesController(IRoleRepository roleRepository)
        {
            _roleRepository =roleRepository;
        }
        [HttpGet]
        public IEnumerable<Role> Get()
        {
           return _roleRepository.GetAll();
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
           Role r=_roleRepository.GetById(id);
           return r.Name;
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        [HttpPut("{id}")]
        public void Put(int id,string name)
        {
            Role r = new Role() { Id = id, Name = name };
            _roleRepository.Update(r);
        }
        [HttpDelete("{id}")]
        public IEnumerable<Role> Delete(int id)
        {
            _roleRepository.Delete(id);
            return _roleRepository.GetAll();
        }
    }
}
