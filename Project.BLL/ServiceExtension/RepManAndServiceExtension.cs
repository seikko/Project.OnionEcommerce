using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ManagerServices.Abstract;
using Project.BLL.ManagerServices.Concrets;
using Project.DAL.Repositories.Abstract;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ServiceExtension
{
   public static  class RepManAndServiceExtension
    {
        public static IServiceCollection AddRepAnManServices(this IServiceCollection services)
        {
            //manuel extension metodumuzu olusturuyoruz
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));


            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            
           
            return services;

            //Manuel Extension metodumuzu olusturduk.
            //StartUp'da cagırırken sadece suunu deriz 
            //services.AddRepAnManServices();
            //Autofac kütüphanesi haricinde bu şekilde kullanımıda olabilir.
        }
    }
}
