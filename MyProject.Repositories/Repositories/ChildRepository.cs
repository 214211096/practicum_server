using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyProject.Repositories.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Child> AddAsync(Child child)
        {
            var newChild = _context.MyChildren.Add(child);
             await _context.SaveChangesAsync();
            return newChild.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var c = await GetByIdAsync(id);
            _context.MyChildren.Remove(c);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.MyChildren.ToListAsync();

        }

        public async Task<Child> GetByIdAsync(int id)
        {
            
            return await _context.MyChildren.Include(u => u.ParentId).FirstOrDefaultAsync(u => u.ChildId == id);

        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var updatedChild = _context.MyChildren.Update(child);
            await _context.SaveChangesAsync();
            return updatedChild.Entity;
        }
    }
}
