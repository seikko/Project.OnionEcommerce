using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.DAL.DALModel;
using Project.ENTITIES.Models;
using Project.MAP.ConfigurationTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.ContextClasses
{
    //Eger kurmak istedigimiz veritabanı yapısında Identity kullanacaksak DbContext'ten miras alamayız.
    //Çünkü Identity kendi tabloları tamamen hazır bir yapı olarak sunar ve bu hazır yapıyı DbContext sağlayamaz.
    //Miras Alacagımız sınıf IdentityDbContext'dir
    //Eger Identity yapısını kullanmıcaksak DbContext yapısını kullanabılırız
   public  class MyContext:IdentityDbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    //Kendi configurasyon yaptıgımız ayarlamaları new'liyoruz burada.
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            base.OnModelCreating(modelBuilder);

        }
       

        //Class'larımızı tablo haline getiriyoruz.
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
 

    }
}
