using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.v2;

[ApiVersion("2", Deprecated = true)]
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
    [MapToApiVersion("2")]
    [Route("Weather")]
    [Obsolete("Deprecated")]
    public IActionResult GetWeatherV2()
    {
        return Ok("version 2");
    }

}
