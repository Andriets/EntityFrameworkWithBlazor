using ClassLibrary1.Context;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces.IRepositories;
using DAL.Owner_Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context) { }

        public IEnumerable<Product> GetProducts(PagingParameters pagingParameters)
        {
            return GetAll().Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
                .Take(pagingParameters.PageSize)
                .ToList();
        }

        public IEnumerable<Product> GetByFilter(PagingParameters pagingParameters)
        {
            if (pagingParameters.Type != "Both")
            {
                int i = pagingParameters.Type == "Window" ? 1 : 2;

                return GetAll().Where(u => u.Price <= pagingParameters.Price)
                    .Where(o => o.ProductTypeId == i)
                    .Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
                    .Take(pagingParameters.PageSize)
                    .ToList();
            }
            else
            {
                return GetAll().Where(u => u.Price <= pagingParameters.Price)
                    .Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
                    .Take(pagingParameters.PageSize)
                    .ToList();
            }

        }
    }
}
