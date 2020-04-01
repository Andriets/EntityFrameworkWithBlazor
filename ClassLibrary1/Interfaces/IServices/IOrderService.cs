using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAll();
        Order GetById(int id);
        void Insert(Order obj);
        void Update(Order obj);
        void Delete(int id);
    }
}
