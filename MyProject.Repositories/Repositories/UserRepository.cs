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
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User details)
        {
            var t = _context.MyUsers.Add(details);
            await _context.SaveChangesAsync();
            return t.Entity;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.MyUsers.Include(user => user.Children).ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.MyUsers.Include(user => user.Children).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
