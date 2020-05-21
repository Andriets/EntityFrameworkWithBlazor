using BLL.DTO;
using ClassLibrary1;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserDTO model)
        {
            var result = await _userService.CreateAsync(model);

            if (result.Success)
            {
                //await _signInManager.SignInAsync(user, false);
                return Ok(result.Success);
            }
            else
            {
                return NotFound(result.Success);
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserDTO model)
        {
                var result = await _userService.SignInAsync(model);

                if (result.Success)
                {
                    //return RedirectToAction("Index", "Home");
                    return Ok(result.Success);
                }
                else
                {
                    return NotFound(result.Message);
                }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            _userService.Logout();
            return RedirectToAction("Index", "Home");
        }
    }
}
