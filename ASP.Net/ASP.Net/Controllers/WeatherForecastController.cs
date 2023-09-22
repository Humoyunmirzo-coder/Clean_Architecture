using Microsoft.AspNetCore.Mvc;

namespace ASP.Net.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost] 
        public Weather Post( [FromBody]Region region )
        {
            if (region.Country=="Uzbekistan" && region.City=="Tashkent")
            {
            return new Weather { Rainy = true, Cloudy = true , Sunny = false , Windy = true };

            }
            return new Weather { Rainy = false, Cloudy = false  , Sunny = true  , Windy = false };
        }
    }
}