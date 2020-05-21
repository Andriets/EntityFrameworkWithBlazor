﻿using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using DAL.Owner_Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

        public IEnumerable<Product> GetAll(PagingParameters productParameters)
        {
            var list = UOW.ProductRepository.GetProducts(productParameters);
            return list.Skip((productParameters.PageNumber - 1) * productParameters.PageSize)
                .Take(productParameters.PageSize)
                .ToList();
        }
        
        public IEnumerable<Product> GetByFilter(PagingParameters productParameters)
        {
            var productlist = UOW.ProductRepository.GetByFilter(productParameters).ToList();
            var typelist = UOW.ProductTypeRepository.GetAll().ToList();
            var res = from pl in productlist
                      join tl in typelist on pl.ProductTypeId equals tl.Id
                      select new { Name = pl.ProductName, Price = pl.Price, ProdType = tl.TypeName };
            if (productParameters.Type != "Both")
            {
                res = res.Where(u => u.ProdType == productParameters.Type);
            }
            List<Product> list = new List<Product>();
            foreach(var item in res)
            {
                Product p = new Product
                {
                    ProductName = item.Name,
                    Price = item.Price
                };
                list.Add(p);
            }
            var reslist = list.Skip((productParameters.PageNumber - 1) * productParameters.PageSize)
                .Take(productParameters.PageSize)
                .ToList();
            return reslist;
        }



        public Task<Product> GetById(int id)
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
