using Newtonsoft.Json;

namespace Weather.Models
{
    public class WeatherDescription
    {
        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
