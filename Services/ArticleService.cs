using BlazorLeBonCoin.DTOs;
using System.Net.Http.Json;

namespace BlazorLeBonCoin.Services
{
    public class ArticleService
    {
        private HttpClient _httpClient;

        public ArticleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ArticleResponseDTO>?> GetArticles()
        {
            return (List<ArticleResponseDTO>?) await _httpClient.GetFromJsonAsync("/api/v1/Article", typeof(List<ArticleResponseDTO>));
        }

        public async Task<ArticleResponseDTO?> GetById(int id)
        {
            return (ArticleResponseDTO?)await _httpClient.GetFromJsonAsync($"/api/v1/Article/{id}", typeof(ArticleResponseDTO));
        }

    }
}
