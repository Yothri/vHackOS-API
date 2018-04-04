using Newtonsoft.Json;

namespace vHackOS.Web.Model
{
    public class App
    {
        [JsonProperty("price")]
        public object Price { get; set; }

        [JsonProperty("appid")]
        public string Appid { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("require")]
        public string Require { get; set; }

        [JsonProperty("maxlvl")]
        public string Maxlvl { get; set; }

        [JsonProperty("baseprice")]
        public int? Baseprice { get; set; }

        [JsonProperty("factor")]
        public int? Factor { get; set; }

        [JsonProperty("running")]
        public string Running { get; set; }
    }

    public sealed class StoreResponse : ResponseBase
    {
        [JsonProperty("lvlup")]
        public string Lvlup { get; set; }

        [JsonProperty("apps")]
        public App[] Apps { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("installed")]
        public string Installed { get; set; }

        [JsonProperty("filled")]
        public string Filled { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("money")]
        public string Money { get; set; }

        [JsonProperty("spam")]
        public string Spam { get; set; }

        [JsonProperty("appCount")]
        public string AppCount { get; set; }
    }
}