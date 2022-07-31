using InmarAPI.Business;

namespace InmarAPI.Service
{
    public class Weather
    {
        public void GetWeather(WebApplication app)
        {
            app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            {
                return Forecast.CreateWeatherForcast();
            })
            .WithName("GetWeatherForecast");
        }
    }
}
