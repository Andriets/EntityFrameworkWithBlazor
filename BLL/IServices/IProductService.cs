using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Task<Product> GetById(int id);
        void Insert(Product obj);
        void Update(Product obj);
        void Delete(int id);
    }
}
