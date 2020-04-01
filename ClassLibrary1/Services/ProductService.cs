using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Services
{
    public class ProductService : IProductService
    {
        IUnitOfWork UOW;

        public ProductService(IUnitOfWork unitOfWork)
        {
            UOW = unitOfWork;
        }

        public void Delete(int id)
        {
            UOW.ProductRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return UOW.ProductRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return UOW.ProductRepository.GetById(id);
        }

        public void Insert(Product obj)
        {
            UOW.ProductRepository.Insert(obj);
        }

        public void Update(Product obj)
        {
            UOW.ProductRepository.Update(obj);
        }
    }
}
