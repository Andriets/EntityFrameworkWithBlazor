using ClassLibrary1;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebApiV3.Controllers
{
    public class OrderController : ControllerBase
    {
        #region Propertirs
        IOrderService _OrderService;
        #endregion

        #region Constructors
        public OrderController(IOrderService sqlOrderService)
        {
            _OrderService = sqlOrderService;
        }
        #endregion

        #region APIs
        [Route("Orders")]
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _OrderService.GetAll();
        }

        [Route("Order/{Id}")]
        [HttpGet]
        public Order Get(int Id)
        {
            return _OrderService.GetById(Id);
        }

        [Route("Order")]
        [HttpPost]
        public void Post([FromBody]Order order)
        {
             _OrderService.Insert(order);
        }

        [Route("Order/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _OrderService.Delete(id);
        }

        #endregion
    }
}
