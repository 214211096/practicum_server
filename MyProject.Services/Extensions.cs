using Microsoft.Extensions.DependencyInjection;
 
using MyProject.Repositories;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyProject.Repositories.Interfaces;

using MyProject.Context;

namespace MyProject.Services
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            
            //services.AddRepositories();
            //services.AddScoped<IUserService, UserService>();
            //services.AddAutoMapper(typeof(Mapping));
            //return services;
            service.AddDbContext<IContext, MyDBContext>();
            service.AddRepositories();
            service.AddAutoMapper(typeof(Mapping));
            service.AddScoped<IUserService, UserService>();
            return service;
        }
    }
}
