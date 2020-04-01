using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);       
    }
}
