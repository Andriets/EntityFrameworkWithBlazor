using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GerAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
