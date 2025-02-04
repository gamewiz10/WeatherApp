using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeatherApp.Models; 
using WeatherApp.Services; 

namespace WeatherApp.Controllers  
{
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index(string city = "New York")
        {
            WeatherData weather = await _weatherService.GetWeatherAsync(city);
            return View(weather);
        }
    }
}
