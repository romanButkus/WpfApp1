using System.Collections;
using System.Collections.Generic;

namespace DLL.Abstractions
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        void Edit(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
