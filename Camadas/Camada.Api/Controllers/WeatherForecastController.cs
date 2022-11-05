using Camada.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace Camada.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IExemploNegocio _exemploNegocio;

        public WeatherForecastController(IExemploNegocio exemploNegocio)
        {
            _exemploNegocio = exemploNegocio;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            _exemploNegocio.HelloWorldNegocio();
            return Ok();
        }
    }
}