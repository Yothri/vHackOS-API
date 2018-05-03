using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public class vhSdk : vhClient<SdkResponse>
    {
        internal vhSdk() : base("sdk.php")
        {
        }

        public SdkResponse BuyExploit()
        {
            var req = CreateRequest();

            req.AddParam("action", "100");

            var res = Execute(req);

            return res;
        }
    }
}