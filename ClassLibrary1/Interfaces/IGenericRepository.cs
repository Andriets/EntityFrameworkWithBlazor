using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GerAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        public void Add();
        
    }
}
