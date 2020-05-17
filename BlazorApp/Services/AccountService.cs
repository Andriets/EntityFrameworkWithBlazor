using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class AccountService
    {
        public HttpClient _httpClient;

        public AccountService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task Login(LoginViewModel model)
        {
            var result = await _httpClient.GetAsync("api/controller");
            result.EnsureSuccessStatusCode();
        }
    }
}
