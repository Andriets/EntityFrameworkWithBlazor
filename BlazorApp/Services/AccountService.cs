using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using BLL.DTO;
using System.Text;
using DAL.Owner_Parameters;
using System.Text.Json;
using BLL;

namespace BlazorApp.Services
{
    public class AccountService
    {
        public HttpClient _httpClient;

        public AccountService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<Information> Login(LoginViewModel model)
        {
            UserDTO user = new UserDTO
            {
                Email = model.Email,
                Role = "User",
                Password = model.Password
            };
            var json = JsonSerializer.Serialize(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/account/login", data);
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<Information>(responseContent);
            
        }

        public async Task<Information> Register(RegisterViewModel model)
        {
            UserDTO user = new UserDTO
            {
                Name = model.Name,
                Email = model.Email,
                Role = "User",
                Password = model.Password
            };
            var json = JsonSerializer.Serialize(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/account/register", data);
            using var responseContent = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<Information>(responseContent);
        }
    }
}
