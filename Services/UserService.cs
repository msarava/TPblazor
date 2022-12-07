using BlazorLeBonCoin.DTOs;
using System.Net.Http.Json;

namespace BlazorLeBonCoin.Services
{
    public class UserService
    {
        private HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }   

        public async Task<UserResponseDto?> GetUserById(int id)
        {
            return (UserResponseDto?)await _httpClient.GetFromJsonAsync($"/api/v1/User/{id}", typeof(UserResponseDto));
        }
    }
}
