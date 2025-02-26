using Newtonsoft.Json;
using System.Collections.Generic;

namespace Weather.Models
{
    public class WeatherApiResponse
    {
        [JsonProperty("main")]
        public MainInfo Main { get; set; }

        [JsonProperty("weather")]
        public List<WeatherDescription> Weather { get; set; }

        [JsonProperty("clouds")]
        public CloudsInfo Clouds { get; set; }
    }
}
