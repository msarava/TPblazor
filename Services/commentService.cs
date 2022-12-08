using BlazorLeBonCoin.DTOs;
using System.Net.Http.Json;

namespace BlazorLeBonCoin.Services
{
    public class commentService
    {
        private HttpClient _httpClient;

        public commentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CommentDto>?> GetComment()
            {
                return (List<CommentDto>?)await _httpClient.GetFromJsonAsync("/api/v1/Comment", typeof(List<CommentDto>));
            }
        
    }
}
