using Project.DAL.ContextClasses;
using Project.DAL.Repositories.Abstract;
using Project.ENTITIES.CoreInterfaces;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
    //BaseRepository gelen hersey generic bir tiptir IRepository'den miras alıyor ilk gorevini BaseEntity için yapacak.
    //IRepository'deki gorevlerimizi Tanımlıyoruz simdi.
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity,IEntity
    {
        MyContext _db;
        public BaseRepository(MyContext db)
        {
            _db = db;
        }
        void Save()
        {
            _db.SaveChanges();
        }
        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        public void AddRange(List<T> item)
        {
            _db.Set<T>().AddRange(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.DeletedDate = DateTime.Now; //silinme işlem tarıhını aldık.
            item.Status = ENTITIES.Enums.DataStatus.Deleted;//veri durumunu Delete a cektık veriyi silmedik aslında....
            Save();
        }

        public void DeleteRange(List<T> item)
        {
            foreach (T element in item)
            {
                Delete(element);
            }
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);//veriyi yok etmek...
            Save();
        }

        public void DestroyRange(List<T> item)
        {
            foreach (T element in item)
            {
                Destroy(element);
            }
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);//veri durumu deleted'a eşit olmayanları getir.
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();//Bütün veriyi getir.
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);//veri durumu updated'a eşit olanı getir.
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);//veri durumu silinmiş olanı getir.
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _db.Set<T>().Select(exp).ToList();
        }

        public void Update(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Updated;//veri durumunu Update'a cek
            item.ModifiedDate = DateTime.Now;//işlem tarihini al
            T tobeUpdated = Find(item.ID);
            _db.Entry(tobeUpdated).CurrentValues.SetValues(item);
            Save();
        }

        public void UpdateRange(List<T> item)
        {
            foreach (T element in item)
            {
                Update(element);
            }
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
