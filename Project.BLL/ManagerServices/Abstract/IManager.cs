using Project.CoreCross.Utilities.Results;
using Project.DAL.DALModel;
using Project.ENTITIES.CoreInterfaces;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Project.BLL.ManagerServices.Abstract
{
   public  interface IManager<T> where T:BaseEntity,IEntity
    {

        IDataResult<List<T>> GetAll();
        IDataResult<List<AppUser>> GetByUserId(int userId);
        IResult Add(T item);
        IResult Update(T item);
        IResult Delete(T item);
        IResult Destroy(T item);

        IDataResult<T> Where(Expression<Func<T, bool>> exp);

        IDataResult<bool> Any(Expression<Func<T, bool>> exp);

        IDataResult<T> FirstOrDefault(Expression<Func<T, bool>> exp);

        IDataResult<object> Select(Expression<Func<T, object>> exp);



    }
}
