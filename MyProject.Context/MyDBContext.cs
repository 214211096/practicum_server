using Microsoft.EntityFrameworkCore;
using System;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using Microsoft.Extensions.Options;
//using System.Data.Entity;

namespace MyProject.Context
{
    public class MyDBContext:DbContext,IContext
    {
        public DbSet<User> MyUsers { get; set; }
        public DbSet<Child> Children { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = MyProjectDB; Trusted_Connection = True");            
        //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=chani_practicum;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //builder =>
        //{
        //    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
        //    //});
        //    base.OnConfiguring(optionsBuilder);
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = MyProjectDB; Trusted_Connection = True");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=practicumDB_chani;Trusted_Connection=True;");

    }
}
