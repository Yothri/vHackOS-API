using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace vHackOS.Web.Model
{
    public class MissionsResponse : ResponseBase
    {
        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("claim")]
        public int Claim { get; set; }

        [JsonProperty("claimed")]
        public int Claimed { get; set; }

        [JsonProperty("claimNextDay")]
        public int ClaimNextDay { get; set; }

        [JsonProperty("nextDailyReset")]
        public string NextDailyReset { get; set; }

        [JsonProperty("daily")]
        public IList<Daily> Daily { get; set; }

        [JsonProperty("dailyCount")]
        public int DailyCount { get; set; }
    }

    public class Daily
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("descr")]
        public string Descr { get; set; }

        [JsonProperty("finished")]
        public int Finished { get; set; }

        [JsonProperty("exp")]
        public int Exp { get; set; }

        [JsonProperty("rewType")]
        public RewardType RewType { get; set; }

        [JsonProperty("rewAmount")]
        public int RewardAmount { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RewardType
    {
        [EnumMember(Value = "NetCoins")] NetCoins,
        [EnumMember(Value = "Boosters")] Boosters
    }
}