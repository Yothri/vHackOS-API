using Newtonsoft.Json;
using System.Collections.Generic;

namespace vHackOS.Web.Model
{
    public class RemoteBankResponse : ResponseBase
    {
        [JsonProperty("withdraw")]
        public string Withdraw { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }
        
        [JsonProperty("ipremoved")]
        public string Ipremoved { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("remoteusername")]
        public string Remoteusername { get; set; }

        [JsonProperty("remotepassword")]
        public string Remotepassword { get; set; }

        [JsonProperty("money")]
        public long Money { get; set; }

        [JsonProperty("remotemoney")]
        public long Remotemoney { get; set; }

        [JsonProperty("savings")]
        public string Savings { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("usrMwk")]
        public string UsrMwk { get; set; }

        [JsonProperty("gotBLT")]
        public string GotBLT { get; set; }

        [JsonProperty("aatt")]
        public int Aatt { get; set; }

        [JsonProperty("nextp")]
        public string Nextp { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("maxsavings")]
        public long Maxsavings { get; set; }

        [JsonProperty("transcount")]
        public long Transcount { get; set; }

        [JsonProperty("transactions")]
        public IList<Transaction> Transactions { get; set; }
    }

    public class Transaction
    {

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("from_id")]
        public string FromId { get; set; }

        [JsonProperty("from_ip")]
        public string FromIp { get; set; }

        [JsonProperty("to_id")]
        public string ToId { get; set; }

        [JsonProperty("to_ip")]
        public string ToIp { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }
    }
}