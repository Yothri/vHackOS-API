using System.Threading.Tasks;
using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public class vhRemoteBank : vhClient<RemoteBankResponse>
    {
        internal vhRemoteBank() : base("remotebanking.php")
        {
        }

        public string TargetIp { get; set; }

        public RemoteBankResponse Withdraw(string targetIp, long amount)
        {
            var req = CreateRequest();

            req.AddParam("target", targetIp);
            req.AddParam("action", "100");
            req.AddParam("amount", amount.ToString());

            var result = Execute(req);

            return result;
        }

        public async Task<RemoteBankResponse> WithdrawAsync(string targetIp, long amount)
        {
            var req = CreateRequest();

            req.AddParam("target", targetIp);
            req.AddParam("action", "100");
            req.AddParam("amount", amount.ToString());

            var result = await ExecuteAsync(req);

            return result;
        }

        public override RemoteBankResponse Update()
        {
            var req = CreateRequest();

            req.AddParam("target", TargetIp);

            return Execute(req);
        }

        public async override Task<RemoteBankResponse> UpdateAsync()
        {
            var req = CreateRequest();

            req.AddParam("target", TargetIp);

            return await ExecuteAsync(req);
        }
    }
}