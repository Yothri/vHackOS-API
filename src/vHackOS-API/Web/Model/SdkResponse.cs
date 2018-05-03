using Newtonsoft.Json;
using vHackOS.Converters;

namespace vHackOS.Web.Model
{
    public class SdkResponse : ResponseBase
    {
        [JsonProperty("applied")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Applied { get; set; }

        [JsonProperty("sdk")]
        public int Sdk { get; set; }

        [JsonProperty("exploits")]
        public int Exploits { get; set; }

        [JsonProperty("nextexploit")]
        public long Nextexploit { get; set; }
    }
}