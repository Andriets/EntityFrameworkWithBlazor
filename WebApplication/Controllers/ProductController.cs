using AutoMapper;
using BLL.DTO;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces.IServices;
using DAL.Owner_Parameters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebApiV3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
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

/*        [HttpGet] 
        public IActionResult Products()
        {
            return View();
        }*/

        [Route("Products")]
        [HttpGet]
        public ActionResult<List<ProductDTO>> Products([FromQuery] PagingParameters pagingParameters)
        {
            var models = _ProductService.GetAll(pagingParameters).ToList();
            var list = _mapper.Map<List<Product>, List<ProductDTO>>(models);
            return list;
           /* if (list == null)
                return NotFound("The list of products is empty");
            else
                return View(list);*/
               // return Ok(list);
        }

        [Route("Search")]
        [HttpGet]
        public ActionResult<List<ProductDTO>> ProductsFilter([FromQuery] PagingParameters pagingParameters)
        {
            var models = _ProductService.GetByFilter(pagingParameters).ToList();
            var list = _mapper.Map<List<Product>, List<ProductDTO>>(models);
            return list;
            /* if (list == null)
                 return NotFound("The list of products is empty");
             else
                 return View(list);*/
            // return Ok(list);
        }

        [Route("Info/{Id}")]
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var product = _ProductService.GetById(Id);
            var res = _mapper.Map<Product, ProductDTO>(product.Result);
            if (res == null)
                return NotFound("Empty");
            else
                return Ok(res);
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
