using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Models;

namespace TestTask.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected Repository(ApplicationContext dbContext)
        {
            DbContext = dbContext;
        }
        protected DbContext DbContext;
        public virtual void Add(T item)
        {
            DbContext.Set<T>().Add(item);
            DbContext.SaveChanges();
        }

        public virtual T Get(int id)
        {
            return GetAll(item => item.Id == id).SingleOrDefault();
        }

        public virtual IQueryable<T> GetAll()
        {
            return DbContext.Set<T>();
        }

        public virtual IQueryable<T> GetAll(Func<T, bool> predicate)
        {
            return DbContext.Set<T>().Where(predicate).AsQueryable();
        }

        public virtual void RemoveById(int id)
        {
            T item = DbContext.Set<T>().Where(i => i.Id == id).SingleOrDefault();
            DbContext.Set<T>().Remove(item);
            DbContext.SaveChanges();
        }

        public virtual void Remove(T item)
        {
            DbContext.Set<T>().Remove(item);
            DbContext.SaveChanges();
        }

        public virtual void Update(T item)
        {
            DbContext.Entry(item).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
