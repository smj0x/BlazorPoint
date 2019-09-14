using Newtonsoft.Json;

namespace lms.Models
{
    public class Metadata
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
