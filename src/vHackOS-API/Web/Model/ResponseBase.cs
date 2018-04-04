using Newtonsoft.Json;

namespace vHackOS.Web.Model
{
    public abstract class ResponseBase
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}