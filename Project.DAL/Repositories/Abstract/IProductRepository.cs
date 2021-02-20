using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Abstract
{

    //IProductRepository aslındabir IRepository'dir diyoruz I Repository' de Product ıcın calısıcak.
    public interface IProductRepository:IRepository<Product>
    {
    }
}
