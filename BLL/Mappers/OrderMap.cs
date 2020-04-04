using AutoMapper;
using BLL.DTO;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mappers
{
    public class OrderMap : Profile
    {
        public OrderMap()
        {
            CreateMap<Order, OrderView>();
        }
    }
}
