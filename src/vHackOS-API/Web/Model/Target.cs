using Newtonsoft.Json;
using vHackOS.Converters;

namespace vHackOS.Web.Model
{
    public class Target
    {
        [JsonProperty("ip")]
        public string IpAddress { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("fw")]
        public int Firewall { get; set; }

        [JsonProperty("open")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool IsOpen { get; set; }
    }
}