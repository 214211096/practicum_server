using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
//using MyProject.Mock;
using MyProject.Services.Interfaces;
using MyProject.WebAPI_1.Models;

namespace myProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService childService)
        {
            _childService =childService;
        }
        [HttpGet]
        public async Task<List<ChildDTO>>  Get()
        {
           return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> GetById(int id)
        {
            return await _childService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task Post([FromBody] ChildModel model)
        {
            ChildDTO childDTO = new ChildDTO()
            {
                
                
                TZ = model.TZ,
                FirstName = model.FirstName,
                DateOfBirth = model.DateOfBirth,
                ParentId = model.ParentId

            };
            await _childService.AddAsync(childDTO);


        }
        [HttpPut("{id}")]
        public async Task<ChildDTO> Put(int id, [FromBody] ChildModel model)
        {
            ChildDTO childDTO = new ChildDTO()
            {
                
                ChildId = id,
                TZ = model.TZ,
                FirstName = model.FirstName,
                DateOfBirth = model.DateOfBirth,
                ParentId = model.ParentId
            };
            return await _childService.UpdateAsync(childDTO);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childService.DeleteAsync(id);
        }
    }
}
