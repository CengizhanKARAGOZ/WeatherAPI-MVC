using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController:ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet("{city}")]
    public async Task<IActionResult> GetWeatherAsync(string city)
    {
        try
        {
            var weather = await _weatherService.GetWeatherAsync(city);
            var weatherData = JsonConvert.DeserializeObject<dynamic>(weather);
            var temperature = weatherData.current.temp_c;
            return Ok(temperature.ToString());
        }
        catch (Exception ex)
        {
            return BadRequest(new {error= ex.Message});
        }
    }
}