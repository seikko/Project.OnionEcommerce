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
   public class OrderManager:BaseManager<Order>,IOrderManager
    {
        public OrderManager(IRepository<Order> ord):base(ord)
        {

        }
        [ValidationAspect(typeof(OrderValidator))]
        public override IResult Update(Order item)
        {
            _irp.Update(item);
            return new SuccessDataResult<Order>(Messanges.Updated);
        }
    }
}
