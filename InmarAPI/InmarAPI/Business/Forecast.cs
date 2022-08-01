using InmarAPI.DataAccess;

namespace InmarAPI.Business
{
    public class Forecast
    {
        public WeatherForecast[] CreateWeatherForcast()
        {
            WeatherConnection connection = new WeatherConnection();

            List<WeatherForecast> forecasts = connection.GetForecasts();

            forecasts.ForEach((WeatherForecast forecast) =>
            {
                int celsius = (int)(5 * (forecast.TemperatureF - 32) / 9);
                forecast.TemperatureC = celsius;
            });

            return forecasts.ToArray();
        }
    }
}
