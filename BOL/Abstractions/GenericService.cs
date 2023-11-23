using DLL.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Abstractions
{
    public class GenericService<T> : IService<T> where T : class
    {
        IRepository<T> _repository;

        public GenericService(IRepository<T> repository) => _repository = repository;

        public void Add(T entity) => _repository.Add(entity);

        public void Edit(T entity) => _repository.Edit(entity);

        public IEnumerable<T> GetAll() => _repository.GetAll();

        public T GetById(int id) => _repository.GetById(id);

        public void Remove(T entity) => _repository.Remove(entity);
    }
}
