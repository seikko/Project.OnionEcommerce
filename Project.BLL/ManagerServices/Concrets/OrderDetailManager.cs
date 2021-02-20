using Project.BLL.Constans.ValidationMessanges;
using Project.BLL.ManagerServices.Abstract;
using Project.BLL.ValidationRules;
using Project.CoreCross.Aspects.AutoFac.Validation;
using Project.CoreCross.Utilities.Results;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ManagerServices.Concrets
{
   public class OrderDetailManager:BaseManager<OrderDetail>,IOrderDetailManager
    {
        public OrderDetailManager(IRepository<OrderDetail> ord):base(ord)
        {

        }
        
      
    }
}
