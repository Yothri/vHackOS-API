using Newtonsoft.Json;
using System.Collections.Generic;
using vHackOS.Converters;

namespace vHackOS.Web.Model
{
    public class NetworkResponse : ResponseBase
    {
        [JsonProperty("tutor")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Tutor { get; set; }

        [JsonProperty("exploits")]
        public int Exploits { get; set; }

        [JsonProperty("connectionCount")]
        public int ConnectionCount { get; set; }

        [JsonProperty("ips")]
        public IList<Target> Targets { get; set; }

        [JsonProperty("cm")]
        public IList<RemoteConnection> Connections { get; set; }
    }
}