using MyFirstStack.Models;

namespace MyFirstStack.Infrastructure
{
    public class DogFactService
    {
        private readonly HttpClient _httpClient;

        public DogFactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DogFact> GetFact(int num = 1)
        {
            DogFact? fact = await _httpClient.GetFromJsonAsync<DogFact>($"api/facts?number={num}");
            
            return fact;
        }
    }
}
