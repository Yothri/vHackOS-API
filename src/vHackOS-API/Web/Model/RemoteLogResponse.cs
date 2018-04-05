using Newtonsoft.Json;

namespace vHackOS.Web.Model
{
    public class RemoteLogResponse : ResponseBase
    {
        [JsonProperty("logs")]
        public string Logs { get; set; }
    }
}