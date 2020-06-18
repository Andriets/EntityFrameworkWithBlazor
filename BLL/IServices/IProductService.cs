using BLL.DTO;
using ClassLibrary1.Entities;
using DAL.Owner_Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll(PagingParameters productParameters);
        IEnumerable<Product> GetByFilter(PagingParameters productParameters);
        Task<Product> GetById(int id);
        void Insert(ProductDTO obj);
        void Update(Product obj);
        void Delete(int id);
    }
}
