using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Mock
{
    public class MockContext  //:IContext
    {
        private int saveIndex;
        public int SaveChanges()
        {
            return ++saveIndex;
        }
        public MockContext()
        {
            //this.Roles = new DbSet<Role>();
            //this.Permissions = new DbSet<Permission>();
            //this.Claims = new DbSet<Claim>();
            saveIndex = 0;
           

        
        
        
        }
    }
}