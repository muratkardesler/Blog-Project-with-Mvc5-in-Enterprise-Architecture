using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Repository<T>:IRepository<T> where T:class
    {
        Context c = new Context(); //context sınıfımıza erişmek için gönderdiğimiz değer
        DbSet<T> _object; // dışarıdan göndereceğimiz değerler
        public Repository()
        {
            _object = c.Set<T>();
        }
        public int Delete(T p)
        {
            _object.Remove(p);
            return c.SaveChanges();

        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T p)
        {
            _object.Add(p); // neye göre ekliyeceksin gönderdiğimiz parametreye göre o yuzden p değerini ekledim parantezin içine
            return c.SaveChanges();
        }

        public IList<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public int Update(T p)
        {
            return c.SaveChanges();
        }
    }
}
