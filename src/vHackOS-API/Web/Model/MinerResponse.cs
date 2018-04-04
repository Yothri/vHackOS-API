using Newtonsoft.Json;

namespace vHackOS.Web.Model
{
    public sealed class MinerResponse : ResponseBase
    {
        [JsonProperty("running")]
        public int Running { get; set; }

        [JsonProperty("applied")]
        public string Applied { get; set; }

        [JsonProperty("claimed")]
        public string Claimed { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("left")]
        public string Left { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("is")]
        public string Is { get; set; }

        [JsonProperty("netcoins")]
        public string Netcoins { get; set; }
    }
}