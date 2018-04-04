using Newtonsoft.Json;

namespace vHackOS.Web.Model
{
    public sealed class UpdateResponse : ResponseBase
    {
        [JsonProperty("expired")]
        public string Expired { get; set; }

        [JsonProperty("easterevent")]
        public string Easterevent { get; set; }

        [JsonProperty("blue")]
        public string Blue { get; set; }

        [JsonProperty("green")]
        public string Green { get; set; }

        [JsonProperty("grey")]
        public string Grey { get; set; }

        [JsonProperty("yellow")]
        public string Yellow { get; set; }

        [JsonProperty("orange")]
        public string Orange { get; set; }

        [JsonProperty("purple")]
        public string Purple { get; set; }

        [JsonProperty("red")]
        public string Red { get; set; }

        [JsonProperty("turkis")]
        public string Turkis { get; set; }

        [JsonProperty("white")]
        public string White { get; set; }

        [JsonProperty("eggs")]
        public string Eggs { get; set; }

        [JsonProperty("newmessage")]
        public string Newmessage { get; set; }

        [JsonProperty("unreadCount")]
        public string UnreadCount { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("exploits")]
        public string Exploits { get; set; }

        [JsonProperty("exp")]
        public string Exp { get; set; }

        [JsonProperty("expreq")]
        public string Expreq { get; set; }

        [JsonProperty("exppc")]
        public string Exppc { get; set; }

        [JsonProperty("netcoins")]
        public string Netcoins { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("money")]
        public string Money { get; set; }

        [JsonProperty("ipaddress")]
        public string Ipaddress { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("fw")]
        public string Fw { get; set; }

        [JsonProperty("av")]
        public string Av { get; set; }

        [JsonProperty("sdk")]
        public string Sdk { get; set; }

        [JsonProperty("ccolor")]
        public string Ccolor { get; set; }

        [JsonProperty("brute")]
        public string Brute { get; set; }

        [JsonProperty("spam")]
        public string Spam { get; set; }

        [JsonProperty("mwk")]
        public string Mwk { get; set; }

        [JsonProperty("mod")]
        public string Mod { get; set; }

        [JsonProperty("crew")]
        public string Crew { get; set; }

        [JsonProperty("miner")]
        public string Miner { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("server")]
        public string Server { get; set; }

        [JsonProperty("minerLeft")]
        public string MinerLeft { get; set; }

        [JsonProperty("chatban")]
        public string Chatban { get; set; }

        [JsonProperty("comCount")]
        public string ComCount { get; set; }

        [JsonProperty("vip")]
        public int Vip { get; set; }

        [JsonProperty("crewMsgCount")]
        public string CrewMsgCount { get; set; }

        [JsonProperty("notepad")]
        public string Notepad { get; set; }

        [JsonProperty("lb")]
        public string Lb { get; set; }

        [JsonProperty("missions")]
        public string Missions { get; set; }

        [JsonProperty("jobs")]
        public string Jobs { get; set; }

        [JsonProperty("community")]
        public string Community { get; set; }

        [JsonProperty("accesstoken")]
        public string Accesstoken { get; set; }

        [JsonProperty("taskfinish")]
        public string Taskfinish { get; set; }

        [JsonProperty("inet")]
        public string Inet { get; set; }
    }
}