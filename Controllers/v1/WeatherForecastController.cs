using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.v1;

[ApiVersion("1")]
[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [MapToApiVersion("1")]
    [Route("Weather")]
    public IActionResult GetWeatherV1()
    {
        return Ok("version 1");
    }

     [HttpGet]
    [MapToApiVersion("2")]
    [Route("Test")]
    public IActionResult Test()
    {
        return Ok("Test Api 2 From version 1");
    }
}
