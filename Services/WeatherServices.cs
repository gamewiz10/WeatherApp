using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;
using System;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private const string API_KEY = "733c44810a3d2091a5da20225b76613b";
        private const string BASE_URL = "https://api.openweathermap.org/data/2.5/weather";

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherData> GetWeatherAsync(string city)
        {
            try
            {
                string url = $"{BASE_URL}?q={city}&appid={API_KEY}&units=metric";
                Console.WriteLine($"🔍 Fetching Weather Data: {url}");

                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"⚠️ API Request Failed: {response.StatusCode}");
                    return new WeatherData { Main = new Main(), Weather = new Weather[0] };
                }

                var json = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Response: {json}"); 

                var weatherData = JsonSerializer.Deserialize<WeatherData>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return weatherData ?? new WeatherData { Main = new Main(), Weather = new Weather[0] };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Exception in WeatherService: {ex.Message}");
                return new WeatherData { Main = new Main(), Weather = new Weather[0] };
            }
        }
    }
}
