using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Repository
{
    public interface IRepository<T>
    {
        T Get(int id);
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Func<T, bool> predicate);
    }
}
