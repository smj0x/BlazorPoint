using Newtonsoft.Json;

namespace dc.Models
{
    public class Metadata
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
