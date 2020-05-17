using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class ProductService
    {
        public HttpClient _httpClient;

        public ProductService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<ProductDTO>> GetAll()
        {
            var res = _httpClient.GetAsync("api/product");
            res.Result.EnsureSuccessStatusCode();

            var responseContent =  res.Result.Content.ReadAsStreamAsync();
            return  await JsonSerializer.DeserializeAsync<List<ProductDTO>>(responseContent.Result);
        }
    }
}
