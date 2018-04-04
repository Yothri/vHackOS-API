using System.Threading.Tasks;
using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public class vhBruteforce : vhClient<BruteforceResponse>
    {
        internal vhBruteforce() : base("startbruteforce.php")
        {
        }

        public BruteforceResponse BruteforceTarget(string targetIp)
        {
            var req = CreateRequest();

            req.AddParam("target", targetIp);

            var result = Execute(req);

            return result;
        }

        public async Task<BruteforceResponse> BruteforceTargetAsync(string targetIp)
        {
            var req = CreateRequest();

            req.AddParam("target", targetIp);

            var result = await ExecuteAsync(req);

            return result;
        }
    }
}