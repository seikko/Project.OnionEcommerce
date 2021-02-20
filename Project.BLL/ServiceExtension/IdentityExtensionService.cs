using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Project.DAL.ContextClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ServiceExtension
{
    public static class IdentityExtensionService
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(x =>
           {
               x.Password.RequireDigit = false;
               x.Password.RequireLowercase = false;
               x.Password.RequireUppercase = false;
               x.Password.RequireNonAlphanumeric = false;
               x.Password.RequiredLength = 3;




           }).AddEntityFrameworkStores<MyContext>();
            return services;
        }
    }
}
