using Project.DAL.ContextClasses;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
   public class OrderRepository:BaseRepository<Order>,IOrderRepository
    {
        public OrderRepository(MyContext db):base(db)
        {

        }
    }
}
