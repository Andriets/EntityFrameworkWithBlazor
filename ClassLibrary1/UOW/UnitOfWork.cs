﻿using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IRepositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        private readonly IProductTypeRepository productTypeRepository;
        public UserManager<User> UserManager { get; private set; }


        public UnitOfWork(IOrderRepository orderRepository,
            IProductRepository productRepository,
            IProductTypeRepository productTypeRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
            this.productTypeRepository = productTypeRepository;
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                return orderRepository;
            }
        }
        public IProductRepository ProductRepository
        {
            get
            {
                return productRepository;
            }
        }
        public IProductTypeRepository ProductTypeRepository
        {
            get
            {
                return productTypeRepository;
            }
        }
    }
}
