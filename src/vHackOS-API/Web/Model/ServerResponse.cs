using Newtonsoft.Json;

namespace vHackOS.Web.Model
{
    public sealed class ServerResponse : ResponseBase
    {
        [JsonProperty("avadded")]
        public string Avadded { get; set; }

        [JsonProperty("fwadded")]
        public string Fwadded { get; set; }

        [JsonProperty("node_updated")]
        public string NodeUpdated { get; set; }

        [JsonProperty("sPackOpen")]
        public string SPackOpen { get; set; }

        [JsonProperty("sPackOpenAll")]
        public string SPackOpenAll { get; set; }

        [JsonProperty("boughtOne")]
        public string BoughtOne { get; set; }

        [JsonProperty("boughtTen")]
        public string BoughtTen { get; set; }

        [JsonProperty("packsBought")]
        public string PacksBought { get; set; }

        [JsonProperty("boughtLimit")]
        public string BoughtLimit { get; set; }

        [JsonProperty("server_str")]
        public int ServerStr { get; set; }

        [JsonProperty("av1_str")]
        public int Av1Str { get; set; }

        [JsonProperty("av2_str")]
        public int Av2Str { get; set; }

        [JsonProperty("av3_str")]
        public int Av3Str { get; set; }

        [JsonProperty("fw1_str")]
        public int Fw1Str { get; set; }

        [JsonProperty("fw2_str")]
        public int Fw2Str { get; set; }

        [JsonProperty("fw3_str")]
        public int Fw3Str { get; set; }

        [JsonProperty("sServer")]
        public int SServer { get; set; }

        [JsonProperty("sAV")]
        public int SAV { get; set; }

        [JsonProperty("sFW")]
        public int SFW { get; set; }

        [JsonProperty("sBoost")]
        public int SBoost { get; set; }

        [JsonProperty("server_pieces")]
        public int ServerPieces { get; set; }

        [JsonProperty("av_pieces")]
        public int AvPieces { get; set; }

        [JsonProperty("fw_pieces")]
        public int FwPieces { get; set; }

        [JsonProperty("packs")]
        public int Packs { get; set; }

        [JsonProperty("server_str_max")]
        public int ServerStrMax { get; set; }

        [JsonProperty("server_str_stars")]
        public string ServerStrStars { get; set; }

        [JsonProperty("avnodes")]
        public int Avnodes { get; set; }

        [JsonProperty("fwnodes")]
        public int Fwnodes { get; set; }

        [JsonProperty("nextpackin")]
        public string Nextpackin { get; set; }
    }
}