using AutoMapper;
using BLL.DTO;
using ClassLibrary1;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace EFWebApiV3.Controllers
{
    public class UserController : /*Controller*/ControllerBase
    {
        #region Propertirs
        IUserService _UserService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public UserController(IUserService userService, IMapper mapper)
        {
            _UserService = userService;
            _mapper = mapper;
        }
        #endregion

        [Route("User")]
        [HttpPost]
        public void Post([FromBody]User user)
        {
            _UserService.CreateAsync(user);
        }

        /*        #region APIs
                [Route("Users")]
                [HttpGet]
                public IActionResult Get()
                {
                    var models = _UserService.GetAll().ToList();
                    var list = _mapper.Map<List<User>, List<UserDTO>>(models);
                    if (list == null)
                        return NotFound("The list is empty");
                    else 
                        return Ok(list);
                }

                [Route("User/{Id}")]
                [HttpGet]
                public Task<User> Get(int Id)
                {
                    return _UserService.GetById(Id);
                }

                [Route("User")]
                [HttpPost]
                public void Post([FromBody]User user)
                {
                    _UserService.Insert(user);
                }

                [Route("User/{Id}")]
                [HttpDelete]
                public void Delete(int id)
                {
                    _UserService.Delete(id);
                }

                #endregion*/
    }
}
