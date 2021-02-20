using Project.BLL.Constans.ValidationMessanges;
using Project.BLL.ManagerServices.Abstract;
using Project.BLL.ValidationRules;
using Project.CoreCross.Aspects.AutoFac.Validation;
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
        // virtual olarak ısaretledik ezmek icin base'lerinde gorev tanımalamak ıstersek burada tanımlama yaparız her manager icin aynı gorevı yapacaktır burası

     
        public  virtual IResult Add(T item)
        {
            //base'e gorev tanımlamak ıstemiyor olabilirsiniz. zaten mıras aldıgım class'lardan ezıcegım icin bu gorevlerı ezmek ıstemezsem her class da 1 gorevı aynı sekılde yerıne getırsın dersem o zaman buraya 1 gorev tanımlarım ve bu gorevler ezilene kadar miras aldıkları butun classlar ıcın calısırlar 
            _irp.Add(item);
            return new SuccessDataResult<BaseEntity>(Messanges.Added); //
        }

        public virtual IDataResult<bool> Any(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public  virtual IResult Delete(T item)
        {
            throw new NotImplementedException();
        }

        public virtual IResult Destroy(T item)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<T> FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<List<T>> GetAll()
        {
            
            return new  SuccessDataResult<List<T>>(_irp.GetAll(),Messanges.Listed);
        }

        public virtual IDataResult<List<AppUser>> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public virtual IDataResult<object> Select(Expression<Func<T, object>> exp)
        {
            throw new NotImplementedException();
        }

        public virtual IResult Update(T item)
        {
            _irp.Update(item);
            return new SuccessDataResult<BaseEntity>(Messanges.Updated);
        }

        public virtual IDataResult<T> Where(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }
    }
}
