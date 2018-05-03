using Newtonsoft.Json;

namespace vHackOS.Web.Model
{
    public class ScanResponse : ResponseBase
    {
        [JsonProperty("fw")]
        public int Fw { get; set; }

        [JsonProperty("ipaddress")]
        public string Ipaddress { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }
    }
}