using ClassLibrary1.Context;
using ClassLibrary1.Interfaces.IRepositories;
using DAL.Owner_Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Repositories
{
    public class OrderRepository : GenericRepository<Order> , IOrderRepository
    {
        public OrderRepository(ApplicationContext context) : base(context) { }
        public IEnumerable<Order> GetOrders(PagingParameters pagingParameters)
        {
            return GetAll().Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
                .Take(pagingParameters.PageSize)
                .ToList();
        }
    }
}
