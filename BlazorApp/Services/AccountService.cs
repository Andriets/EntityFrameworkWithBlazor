using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BLL.DTO;
using System.Text;
using DAL.Owner_Parameters;
using System.Text.Json;

namespace BlazorApp.Services
{
    public class AccountService
    {
        public HttpClient _httpClient;

        public AccountService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<string> Login(LoginViewModel model)
        {
            UserDTO user = new UserDTO
            {
                Email = model.Email,
                Role = "User",
                Password = model.Password
            };
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/account/login", data);
            var ret = response.Content.ReadAsStringAsync().Result;
            return ret;
        }

        public async Task<string> Register(RegisterViewModel model)
        {
            UserDTO user = new UserDTO
            {
                Name = model.Name,
                Email = model.Email,
                Role = "User",
                Password = model.Password
            };
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/account/register", data);
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
