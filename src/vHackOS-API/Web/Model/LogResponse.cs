using Newtonsoft.Json;

namespace vHackOS.Web.Model
{
    public class LogResponse : ResponseBase
    {
        [JsonProperty("logs")]
        public string Logs { get; set; }
    }
}