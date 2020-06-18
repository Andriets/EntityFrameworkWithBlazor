using AutoMapper;
using BLL.DTO;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using DAL.Owner_Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class ProductTypeService : IProductTypeService
    {
        IUnitOfWork UOW;
        public ProductTypeService(IUnitOfWork unitOfWork)
        {
            UOW = unitOfWork;
        }

        public void Delete(int id)
        {
            UOW.ProductTypeRepository.Delete(id);
        }

        public IEnumerable<ProductType> GetAll()
        {
            return  UOW.ProductTypeRepository.GetAll();
        }

        public Task<ProductType> GetById(int id)
        {
            return UOW.ProductTypeRepository.GetById(id);
        }

        public void Insert(ProductType obj)
        {
            UOW.ProductTypeRepository.Insert(obj);
        }

        public void Update(ProductType obj)
        {
            UOW.ProductTypeRepository.Update(obj);
        }
    }
}
