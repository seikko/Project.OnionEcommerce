using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Project.CoreCross.DataAccess.EntityFramework
{
    public class BaseEfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : IdentityDbContext, new()
    {
        public void Add(TEntity item)
        {
            using(TContext context = new TContext())
            {
                var addedEntity = context.Entry(item);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void AddRange(List<TEntity> item)
        {
            using(TContext context = new TContext())
            {
               
            }
        }

        public bool Any(Expression<Func<TEntity, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity item)
        {
            using (TContext context = new TContext())
            {
                //var deletedEntity = context.Entry(item);
                //deletedEntity.State = EntityState.Deleted;
                //context.SaveChanges();
            }
        }

        public void DeleteRange(List<TEntity> item)
        {
            throw new NotImplementedException();
        }

        public void Destroy(TEntity item)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(item);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void DestroyRange(List<TEntity> item)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> exp)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(exp);
            }
        }

        public List<TEntity> GetActives()
        {
            //using (TContext context = new TContext())
            //{
            //    return context.Set<TEntity>().Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
            //}
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetModifieds()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetPassives()
        {
            throw new NotImplementedException();
        }

        public object Select(Expression<Func<TEntity, object>> exp)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<TEntity> item)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Where(Expression<Func<TEntity, bool>> exp)
        {
            throw new NotImplementedException();
        }
    }
}
