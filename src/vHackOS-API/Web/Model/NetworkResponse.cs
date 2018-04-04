using Newtonsoft.Json;
using System.Collections.Generic;

namespace vHackOS.Web.Model
{
    public class NetworkResponse : ResponseBase
    {
        [JsonProperty("tutor")]
        public string Tutor { get; set; }

        [JsonProperty("exploits")]
        public string Exploits { get; set; }

        [JsonProperty("connectionCount")]
        public string ConnectionCount { get; set; }

        [JsonProperty("ips")]
        public IList<IP> Ips { get; set; }

        [JsonProperty("cm")]
        public IList<Cm> Cm { get; set; }
    }

    public class IP
    {

        [JsonProperty("ip")]
        public string IPAddress { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("fw")]
        public int Firewall { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }
    }

    public class Cm
    {

        [JsonProperty("ip")]
        public string IPAddress { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("brute")]
        public string Brute { get; set; }
    }
}