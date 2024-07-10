using Microsoft.AspNetCore.Mvc;

namespace agro_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrevisaoTempoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PrevisaoTempoController> _logger;

        public PrevisaoTempoController(ILogger<PrevisaoTempoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPrevisaoTempo")]
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
    }
}
