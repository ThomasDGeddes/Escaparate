using System.Data.SqlClient;

namespace InmarAPI.DataAccess
{
    public class WeatherConnection
    {
        private List<WeatherForecast> forecasts = new List<WeatherForecast>();

        public List<WeatherForecast> GetForecasts()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-8V1JLQU;Initial Catalog=master;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Weather";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                WeatherForecast forecast = new WeatherForecast();
                                forecast.Date = reader.GetDateTime(1);
                                forecast.TemperatureF = reader.GetInt32(2);
                                forecast.Summary = reader.GetString(3);

                                forecasts.Add(forecast);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return forecasts;
        }
    }
}
