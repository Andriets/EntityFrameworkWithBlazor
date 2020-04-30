using ClassLibrary1.Entities;
using DAL.Owner_Parameters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Interfaces.IRepositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetProducts(PagingParameters productParameters);
    }
}
