using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IRepositories;
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
        private readonly IUserRepository userRepository;

        public UnitOfWork(IOrderRepository orderRepository,
            IProductRepository productRepository,
            IProductTypeRepository productTypeRepository,
            IUserRepository userRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
            this.productTypeRepository = productTypeRepository;
            this.userRepository = userRepository;
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
        public IUserRepository UserRepository
        {
            get
            {
                return userRepository;
            }
        }
    }
}
