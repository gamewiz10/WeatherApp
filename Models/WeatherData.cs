using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace WeatherApp.Models
{

    public class WeatherData
    {
        public Main Main { get; set; }
        public Weather[] Weather { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
        public float Humidity { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
    }
}