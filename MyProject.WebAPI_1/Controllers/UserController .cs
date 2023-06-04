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
        public async Task<List<UserDTO>> GetAllAsync()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDTO> GetByIdAsync(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> AddAsync([FromBody] UserModel d)
        {
            return await _userService.AddAsync(new UserDTO { FirstName = d.FirstName, LastName = d.LastName, IdNumber = d.IdNumber, BirthDate = d.BirthDate, Gender = d.Gender, HMO = d.HMO, Children = d.Children });
        }
    }
}
