using Newtonsoft.Json;
using vHackOS.Web.Model;

namespace vHackOS.Web.Model
{
    public sealed class TasksResponse : ResponseBase
    {
        [JsonProperty("finishall")]
        public string Finishall { get; set; }

        [JsonProperty("aborted")]
        public string Aborted { get; set; }

        [JsonProperty("bruteremoved")]
        public string Bruteremoved { get; set; }

        [JsonProperty("bruteaborted")]
        public string Bruteaborted { get; set; }

        [JsonProperty("brutefinished")]
        public string Brutefinished { get; set; }

        [JsonProperty("finished")]
        public string Finished { get; set; }

        [JsonProperty("bruteretry")]
        public string Bruteretry { get; set; }

        [JsonProperty("boosted")]
        public string Boosted { get; set; }

        [JsonProperty("lvlup")]
        public string Lvlup { get; set; }

        [JsonProperty("updateCount")]
        public int UpdateCount { get; set; }

        [JsonProperty("updates")]
        public Update[] Updates { get; set; }

        [JsonProperty("finishallcosts")]
        public long Finishallcosts { get; set; }

        [JsonProperty("nextdone")]
        public string Nextdone { get; set; }

        [JsonProperty("bruteCount")]
        public int BruteCount { get; set; }

        [JsonProperty("brutes")]
        public Brute[] Brutes { get; set; }

        [JsonProperty("nextdone2")]
        public string Nextdone2 { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("netcoins")]
        public int Netcoins { get; set; }

        [JsonProperty("boosters")]
        public int Boosters { get; set; }
    }

    public class Update
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("appid")]
        public AppType Appid { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("now")]
        public int Now { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }
    }

    public class Brute
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user_ip")]
        public string UserIp { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("now")]
        public string Now { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}