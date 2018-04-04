using Newtonsoft.Json;
using System;

namespace vHackOS.Web.Model
{
    public sealed class LoginCredentials : ResponseBase
    {
        internal LoginCredentials()
        {
        }

        public static LoginCredentials Create(int userId, string accessToken)
        {
            if (userId == 0 || string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentException($"Invalid {nameof(userId)} or {nameof(accessToken)}");

            return new LoginCredentials
            {
                UserID = userId,
                AccessToken = accessToken
            };
        }

        [JsonProperty("accesstoken")]
        public string AccessToken { get; set; }

        [JsonProperty("uid")]
        public int UserID { get; set; }
    }
}