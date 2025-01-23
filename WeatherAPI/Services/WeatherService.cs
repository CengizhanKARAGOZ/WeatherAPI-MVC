namespace WeatherAPI.Services;

public class WeatherService:IWeatherService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    
    public WeatherService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<string> GetWeatherAsync(string city)
    {
        var apiKey = _configuration["WeatherAPI:APIKey"];
        var url = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={city}&aqi=no";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}