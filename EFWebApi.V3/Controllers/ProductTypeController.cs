using AutoMapper;
using BLL.DTO;
using ClassLibrary1;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWebApiV3.Controllers
{
    public class ProductTypeController : ControllerBase
    {
        #region Propertirs
        IProductTypeService _ProductTypeService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public ProductTypeController(IProductTypeService productType, IMapper mapper)
        {
            _ProductTypeService = productType;
            _mapper = mapper;
        }
        #endregion

        #region APIs
        [Route("ProductTypes")]
        [HttpGet]
        public IActionResult Get()
        {
            var models = _ProductTypeService.GetAll().ToList();
            var list = _mapper.Map<List<ProductType>, List<ProductTypeDTO>>(models);
            if (list == null)
                return NotFound("Empty");
            else
                return Ok(list);
        }

        [Route("ProductType/{Id}")]
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var productType = _ProductTypeService.GetById(Id);
            var res = _mapper.Map<ProductType, ProductTypeDTO>(productType.Result);
            if (res == null)
                return NotFound("Empty");
            else
                return Ok(res);
        }

        [Route("ProductType")]
        [HttpPost]
        public void Post([FromBody]ProductType productType)
        {
            _ProductTypeService.Insert(productType);
        }

        [Route("ProductType/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _ProductTypeService.Delete(id);
        }

        #endregion
    }
}
