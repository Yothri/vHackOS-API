using Newtonsoft.Json;

namespace vHackOS.Web.Model
{
    public class RemoteConnection
    {
        [JsonProperty("ip")]
        public string IpAddress { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("brute")]
        public BruteState BruteState { get; set; }
    }
}