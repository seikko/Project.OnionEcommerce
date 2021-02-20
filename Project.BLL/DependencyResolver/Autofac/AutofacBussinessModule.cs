using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ManagerServices.Abstract;
using Project.BLL.ManagerServices.Concrets;
using Project.CoreCross.Utilities.Interceptors;
using Project.DAL.ContextClasses;
using Project.DAL.DALModel;
using Project.DAL.Repositories.Abstract;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.DependencyResolver.Autofac
{
   public  class AutofacBussinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(BaseManager<>)).As(typeof(IManager<>)).SingleInstance();
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IRepository<>)).SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductManager>().SingleInstance();//ProductManager'i gordugunde I ProductManager i ver. SingelInstance ise 1 kere instance al ve bundan sonra aldıgın ınstance döndür.
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            builder.RegisterType<CategoryManager>().As<ICategoryManager>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();



            builder.RegisterType<OrderDetailManager>().As<IOrderDetailManager>();
            builder.RegisterType<OrderDetailRepository>().As<IOrderDetailRepository>();

            builder.RegisterType<OrderManager>().As<IOrderManager>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();





            builder.RegisterType<UserManagerSpecial>().As<IUserManagerSpecial>();
            builder.RegisterType<LoginManager>().As<ILoginManager>();


            IServiceCollection ni = new ServiceCollection();

            ni.AddIdentity<AppUser, IdentityRole>(x => { x.Password.RequireDigit = false; x.Password.RequireLowercase = false; x.Password.RequireUppercase = false; x.Password.RequireNonAlphanumeric = false; x.Password.RequiredLength = 5; }).AddEntityFrameworkStores<MyContext>();

            //bu noktada kesinlikle builder, Populate metodu ile Identity eklenmiş olan ServiceCollection nesnesini almak zorundadır...Yoksa Identity tablolarınızı acsa bile onun işlemlerini kullanamazsınız...Yani DI Identity icin calısmaz...Sadece tablolar acılmıs olur...

            builder.Populate(ni); //böylece Identity'niz builder nesnenize eklenmiş oluyor...

            builder.Register(c =>
            {

                IConfiguration config = c.Resolve<IConfiguration>();

                DbContextOptionsBuilder<MyContext> opt = new DbContextOptionsBuilder<MyContext>();

                opt.UseSqlServer(config.GetSection("ConnectionStrings:MyConnection").Value).UseLazyLoadingProxies();

                return new MyContext(opt.Options);
            }).AsSelf().InstancePerLifetimeScope();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
