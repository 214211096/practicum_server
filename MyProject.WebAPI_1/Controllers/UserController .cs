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
using static Azure.Core.HttpHeader;

namespace myProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService =userService;
        }
        [HttpGet]
        public async Task<List<UserDTO>>  Get()
        {
           return await _userService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<UserDTO> GetById(int id)
        {
            return await _userService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserModel model)
        {
            UserDTO userDTO = new UserDTO()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                TZ = model.TZ,
                DateOfBirth = model.DateOfBirth,
                Gender = (eGenderDTO)model.Gender,
                HMO = (eHMODTO)model.HMO
            };

            return await _userService.AddAsync(userDTO);

        }

  
        [HttpPut("{id}")]
        public async Task<UserDTO> Put(int id, [FromBody] UserModel model)
        {
            UserDTO userDTO = new UserDTO()
            {
                UserId=id,
              FirstName=model.FirstName,
              LastName=model.LastName,
              TZ=model.TZ   ,
              DateOfBirth=model.DateOfBirth,
                Gender = (eGenderDTO)model.Gender,
                HMO = (eHMODTO)model.HMO
            };
        return   await _userService.UpdateAsync(userDTO);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
