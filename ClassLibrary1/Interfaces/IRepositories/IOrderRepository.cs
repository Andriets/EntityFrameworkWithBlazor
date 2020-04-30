using DAL.Owner_Parameters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Interfaces.IRepositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        IEnumerable<Order> GetOrders(PagingParameters productParameters);
    }
}
