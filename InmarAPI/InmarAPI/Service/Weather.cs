using InmarAPI.Business;

namespace InmarAPI.Service
{
    public class Weather
    {
        public void GetWeather(WebApplication app)
        {
            Forecast forecast = new Forecast();

            app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            {
                return forecast.CreateWeatherForcast();
            })
            .WithName("GetWeatherForecast");
        }
    }
}
