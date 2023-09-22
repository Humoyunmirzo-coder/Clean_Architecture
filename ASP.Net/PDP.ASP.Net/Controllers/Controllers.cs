using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace PDP.ASP.Net.Controllers
{
    [ApiController]
    [Route("controller")]
    public class Controllers : ControllerBase
    {
        public static readonly string[] sammeries = new[]
        {
            "Frething" , " Backering " , "Chill" , "Coold" , " Nild", "Hold"
        };
        private readonly ILogger<Controller> _logger;
        public Controllers(ILogger<Controller> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetControllers")]
        public IEnumerable<Controllerrs> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Controllerrs
            {
                Date = DateTime.Now.AddDays(index  ),
                TempratureC = Random.Shared.Next(-20, 55),
                sammery = sammeries[Random.Shared.Next(sammeries.Length)]
            })
                .ToArray();
                
        }
        [HttpPost]
        public Weather Post ([FromBody] Region region)
        {
            if (region.Countrty =="Uzbekistan" && region.City=="Tashkent" )
            {
               return new Weather {  Runy = true , Cloudy = true , Sunny = false , Windy =true };
            }
            else
            {
               return new Weather {  Runy = false , Cloudy = false  , Sunny = true  , Windy =false  };

            }

        }
    }
}
