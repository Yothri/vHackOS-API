using Newtonsoft.Json;
using vHackOS.Converters;

namespace vHackOS.Web.Model
{
    public sealed class MinerResponse : ResponseBase
    {
        [JsonProperty("running")]
        public MinerState MinerState { get; set; }

        [JsonProperty("applied")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Applied { get; set; }

        [JsonProperty("claimed")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Claimed { get; set; }

        [JsonProperty("started")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool StartSuccessful { get; set; }

        [JsonProperty("left")]
        public int Left { get; set; }

        [JsonProperty("need")]
        public int Need { get; set; }

        [JsonProperty("is")]
        public int Is { get; set; }

        [JsonProperty("netcoins")]
        public int Netcoins { get; set; }

        [JsonProperty("gpuCount")]
        public int GPUCount { get; set; }

        [JsonProperty("upgraded")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Upgraded { get; set; }

    }
}