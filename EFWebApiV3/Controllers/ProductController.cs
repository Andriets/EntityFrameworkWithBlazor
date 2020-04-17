using AutoMapper;
using BLL.DTO;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebApiV3.Controllers
{
    public class ProductController : ControllerBase
    {
        #region Propertirs
        IProductService _ProductService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public ProductController(IProductService product, IMapper mapper)
        {
            _ProductService = product;
            _mapper = mapper;
        }
        #endregion

        #region APIs
        [Route("Products")]
        [HttpGet]
        public IEnumerable<ProductDTO> Get()
        {
            var models = _ProductService.GetAll().ToList();

            return _mapper.Map<List<Product>, List<ProductDTO>>(models);
        }

        [Route("Product/{Id}")]
        [HttpGet]
        public Task<Product> Get(int Id)
        {
            return _ProductService.GetById(Id);
        }

        [Route("Product")]
        [HttpPost]
        public void Post([FromBody]Product product)
        {
            _ProductService.Insert(product);
        }

        [Route("Product/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _ProductService.Delete(id);
        }

        #endregion
    }
}
