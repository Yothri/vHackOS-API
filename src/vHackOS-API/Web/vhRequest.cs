using Newtonsoft.Json.Linq;
using System;
using System.Text;
using vHackOS.Cryptography;

namespace vHackOS.Web
{
#if !DEBUG
    internal sealed class vhRequest
#else
    public sealed class vhRequest
#endif
    {
        private static byte[] WEBSAFE_ALPHABET = new byte[] { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 45, 95 };

        private JObject RequestBody;

        internal vhRequest()
        {
            RequestBody = new JObject();
            SetLanguage("german");
        }

        internal void SetLanguage(string language)
        {
            RequestBody["lang"] = language;
        }

#if !DEBUG
        internal void AddParam(string key, string value)
#else
        public void AddParam(string key, string value)
#endif
        {
            if (RequestBody == null)
                throw new InvalidOperationException("You first have to initialize this client.");

            RequestBody[key] = value;
        }

        internal string GetRequestPayload()
        {
            var str = RequestBody.ToString();
            var strB = Encoding.Default.GetBytes(str);
            var encStr = vhCrypto.encode(strB, 0, strB.Length, WEBSAFE_ALPHABET, false);
            var pass = vhCrypto.GetMD5HashString(str + str + vhCrypto.GetMD5HashString(str));
            return $"?user={encStr}&pass={pass}";
        }
    }
}