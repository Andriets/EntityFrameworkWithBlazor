using BlazorApp.Models;
using BLL.DTO;
using DAL.Owner_Parameters;
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

        public async Task<List<ProductView>> GetAll(PagingParameters p)
        {
            var res = await _httpClient.GetAsync($"api/product/Products?pageNumber={p.PageNumber}&pageSize={p.PageSize}");
            res.EnsureSuccessStatusCode();

            using var responseContent = await res.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<ProductView>>(responseContent);
        }
        public async Task<ProductView> GetById(int id)
        {
            var res = await _httpClient.GetAsync($"api/product/info/{id}");
            res.EnsureSuccessStatusCode();

            using var responseContent = await res.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<ProductView>(responseContent);
        }


        public async Task<List<ProductView>> GetByFilter(PagingParameters p)
        {
            var res = await _httpClient.GetAsync($"api/product/Search?pageNumber={p.PageNumber}&pageSize={p.PageSize}&price={p.Price}&type={p.Type}");
            res.EnsureSuccessStatusCode();

            using var responseContent = await res.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<ProductView>>(responseContent);
        }
    }
}
