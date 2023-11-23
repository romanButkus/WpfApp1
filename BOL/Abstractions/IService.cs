using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Abstractions
{
    public interface IService<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        void Edit(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);


    }
}
