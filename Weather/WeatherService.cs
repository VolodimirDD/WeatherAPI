using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Weather.Models;

public interface IWeatherService
{
    Task<WeatherInfo> GetWeatherAsync(string city);
}

public class WeatherService : IWeatherService
{
    private static readonly string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
    private const string ApiUrl = "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric";

    public async Task<WeatherInfo> GetWeatherAsync(string city)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string url = string.Format(ApiUrl, city, ApiKey);
                HttpResponseMessage response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Error retrieving data: {response.ReasonPhrase}", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                string responseString = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<WeatherApiResponse>(responseString);

                if (data?.Main == null || data.Weather == null || data.Weather.Count == 0)
                {
                    MessageBox.Show("Failed to retrieve weather data. Please check the response format or try again later.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                return new WeatherInfo
                {
                    Temp = data.Main.Temp,
                    TempMin = data.Main.TempMin,
                    TempMax = data.Main.TempMax,
                    Humidity = data.Main.Humidity,
                    Cloudiness = data.Clouds.All,
                    IsRaining = data.Weather[0].Main.Contains("Rain"),
                    Description = data.Weather[0].Description,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}