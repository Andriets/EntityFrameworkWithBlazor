using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface IProductTypeService
    {
        IEnumerable<ProductType> GetAll();
        Task<ProductType> GetById(int id);
        void Insert(ProductType obj);
        void Update(ProductType obj);
        void Delete(int id);
    }
}
