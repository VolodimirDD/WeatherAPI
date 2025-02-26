
namespace Weather.Models
{
    public class WeatherInfo
    {
        public double Temp { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public int Humidity { get; set; }
        public int Cloudiness { get; set; }
        public bool IsRaining { get; set; }
        public string Description { get; set; }
    }
}
