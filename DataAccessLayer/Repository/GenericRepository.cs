using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T Entity)
        {
            using var c = new Context();
            c.Remove(Entity);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);

        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T Entity)
        {
            using var c = new Context();
            c.Add(Entity);
            c.SaveChanges();
        }

        public void Update(T Entity)
        {
            using var c = new Context();
            c.Update(Entity);
            c.SaveChanges();
        }
    }
}
