using Newtonsoft.Json;

namespace Weather.Models
{
    public class CloudsInfo
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }
}
