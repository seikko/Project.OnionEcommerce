using Project.DAL.ContextClasses;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
    //IRepository'den miras almamızın sebebi Dependency Injection için interfaceleri bir çatı altına topluyorum.
    //bu yapı sayesınde IProductRepository gordugunde bana git ProductRepository'i ver diyorum.....
  public  class ProductRepository:BaseRepository<Product>,IProductRepository
    {
        public ProductRepository(MyContext db):base(db)
        {

        }
    }
}
