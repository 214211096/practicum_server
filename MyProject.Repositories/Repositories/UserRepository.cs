using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class UserRepository:IUserRepository
    {
       
            private readonly IContext _context;
            public UserRepository(IContext context)
            {
                _context = context;
            }
            public async Task<User> AddAsync(User user)
            {

                var newUser = _context.MyUsers.Add(user);
                await _context.SaveChangesAsync();
                return newUser.Entity;
            }

            public async Task DeleteAsync(int id)
            {
                var u = await GetByIdAsync(id);
                _context.MyUsers.Remove(u);
                await _context.SaveChangesAsync();
            }

            public async Task<List<User>> GetAllAsync()
            {
                return await _context.MyUsers.ToListAsync();
            }

            public async Task<User> GetByIdAsync(int id)
            {
                return await _context.MyUsers.FindAsync(id);

            }

            public async Task<User> UpdateAsync(User user)
            {
                var updateUser = _context.MyUsers.Update(user);
                await _context.SaveChangesAsync();
                return updateUser.Entity;
            }
        }
    }


