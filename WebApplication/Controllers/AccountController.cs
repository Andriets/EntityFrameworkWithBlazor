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
    public class AccountController : Controller
    {
        IUserService _userService;
        private readonly SignInManager<User> _signInManager;

        public AccountController(IUserService userService, SignInManager<User> signInManager)
        {
            _userService = userService;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDTO user = new UserDTO
                {
                    Name = model.Name,
                    Email = model.Email,
                    Password = model.Password
                };

                var result = _userService.CreateAsync(user);
                if (result.Result.Success)
                {
                    //await _signInManager.SignInAsync(user, false);
                    return Ok(result.Result.Message);
                }
                else
                {
                    return NotFound(result.Result.Message);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDTO userDTO = new UserDTO()
                {
                    Email = model.Email,
                    Password = model.Password
                };
                var result = _userService.SignInAsync(userDTO);

                if (result.Result.Success)
                {
                    return RedirectToAction("Index", "Home");
                    //return Ok(result.Result.Message);
                }
                else
                {
                    return NotFound(result.Result.Message);
                }
            }
            return View(model);
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
