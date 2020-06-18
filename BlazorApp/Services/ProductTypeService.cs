using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class ProductTypeService
    {
        public HttpClient _httpClient;

        public ProductTypeService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<ProductTypeViewModel>> GetAll()
        {
            var res = await _httpClient.GetAsync($"api/productType/ProductTypes");
            res.EnsureSuccessStatusCode();

            using var responseContent = await res.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<ProductTypeViewModel>>(responseContent);
        }
    }
}
