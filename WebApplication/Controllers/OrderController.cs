using AutoMapper;
using BLL.DTO;
using ClassLibrary1;
using ClassLibrary1.Interfaces.IServices;
using DAL.Owner_Parameters;
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
        IMapper _mapper;
        #endregion

        #region Constructors
        public OrderController(IOrderService sqlOrderService, IMapper mapper)
        {
            _OrderService = sqlOrderService;
            _mapper = mapper;
        }
        #endregion
        #region APIs
        [Route("Orders")]
        [HttpGet]
        public IActionResult Get([FromQuery] PagingParameters pagingParameters)
        {
            var models = _OrderService.GetAll(pagingParameters).ToList();
            var list = _mapper.Map<List<Order>, List<OrderDTO>>(models);
            if (list == null)
                return NotFound("Empty");
            else
                return Ok(list);
        }

        [Route("Order/{Id}")]
        [HttpGet]
        public IActionResult Get(int Id)
        {
            Order order = _OrderService.GetById(Id);
            var res = _mapper.Map<Order, OrderDTO>(order);
            if (res == null)
                return NotFound();
            else
                return Ok(res);
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
