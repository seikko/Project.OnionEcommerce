using Project.ENTITIES.CoreInterfaces;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Project.DAL.Repositories.Abstract
{
   public  interface IRepository<T> where T:BaseEntity
    {
        //List Commands

        List<T> GetAll();

        List<T> GetPassives();

        List<T> GetModifieds();

        List<T> GetActives();


        //Modification Commands

        void Add(T item);

        void AddRange(List<T> item);

        void Delete(T item);

        void DeleteRange(List<T> item);

        void Destroy(T item);

        void DestroyRange(List<T> item);

        void Update(T item);


        void UpdateRange(List<T> item);

        //Expression commands

        List<T> Where(Expression<Func<T, bool>> exp);

        bool Any(Expression<Func<T, bool>> exp);

        T FirstOrDefault(Expression<Func<T, bool>> exp);

        object Select(Expression<Func<T, object>> exp);

        //Find command

        T Find(int id);

    }
}
