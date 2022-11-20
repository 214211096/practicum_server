using Microsoft.EntityFrameworkCore;
using System;
using MyProject.Repositories.Entities;
namespace MyProject.Context
{
    public class MyDBContext:DbContext
    {
        public DbSet<Role> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = MyProjectDB; Trusted_Connection = True");
        }


        
    }
}
