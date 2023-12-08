using Microsoft.AspNetCore.Mvc;

namespace AulaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public string HelloWorld()
        {
            return "Hello world atos UFN 2023";
        }

        [HttpPost]
        [Route("hello")]
        public string HelloWorldPost([FromBody] string nome)
        {
            return "Hello world atos UFN 2023" + nome;
        }

        [HttpGet]
        [Route("Exercicio1-P1")]
        public string nome()
        {
            return "Alisson";
        }

        [HttpGet]
        [Route("Exercicio1-P2")]
        public string idade()
        {
            return "20";
        }

        [HttpPost]
        [Route("Exercicio1-P3")]
        public string PostNome([FromBody] string nome)
        {
            return nome;
        }

        [HttpPost]
        [Route("Exercicio1-P4/{idade}")]
        public string PostNomeIdade([FromBody] string nome, [FromRoute]int idade)
        {
            if (idade > 18)
                return $"{nome} é maior de idade";
            else
                return $"{nome} é menor de idade";
        }

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
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}