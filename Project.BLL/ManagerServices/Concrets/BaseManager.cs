using Project.BLL.Constans.ValidationMessanges;
using Project.BLL.ManagerServices.Abstract;
using Project.CoreCross.Utilities.Results;
using Project.DAL.DALModel;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.CoreInterfaces;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Project.BLL.ManagerServices.Concrets
{
    public class BaseManager<T> : IManager<T> where T : BaseEntity, IEntity
    {
        protected IRepository<T> _irp;
        public BaseManager(IRepository<T> irp)
        {
            _irp = irp;
        }
        //polimorfizm ile ezmek icin virtaul keywordu koyuyoruz
        public virtual IResult Add(T item)
        {
            _irp.Add(item);
            return new SuccessDataResult<BaseEntity>(Messanges.Added);
        }

        public virtual IDataResult<bool> Any(Expression<Func<T, bool>> exp)
        {
            _irp.Any(exp);
            return new SuccessDataResult<bool>(Messanges.Added);
        }

        public virtual IResult Delete(T item)
        {//veri durumunu deleted'a cekmek
            _irp.Delete(item);
            return new SuccessDataResult<BaseEntity>(Messanges.Deleted);
        }

        public virtual IResult Destroy(T item)
        {
            _irp.Destroy(item);
            return new SuccessDataResult<BaseEntity>(Messanges.Deleted);
        }

        public virtual IDataResult<T> FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            _irp.FirstOrDefault(exp);
            return new SuccessDataResult<T>(Messanges.Listed);
        }

        public virtual IDataResult<List<T>> GetAll()
        {
            
            return new SuccessDataResult<List<T>>(_irp.GetAll(),Messanges.Listed);
        }

        public virtual IDataResult<List<AppUser>> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<object> Select(Expression<Func<T, object>> exp)
        {
            _irp.Select(exp);
            return new SuccessDataResult<object>(Messanges.Listed);
        }

        public virtual IResult Update(T item)
        {
            _irp.Update(item);
            return new SuccessDataResult<BaseEntity>(Messanges.Updated);
        }

        public virtual IDataResult<T> Where(Expression<Func<T, bool>> exp)
        {
            _irp.Where(exp);
            return new SuccessDataResult<T>(Messanges.Listed);
        }
    }
}
