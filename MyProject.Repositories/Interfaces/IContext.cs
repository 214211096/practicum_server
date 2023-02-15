using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace MyProject.Repositories.Interfaces
{
   public interface IContext
    {
        public DbSet<User> MyUsers { get; set; }
        public DbSet<Child> MyChildren { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
