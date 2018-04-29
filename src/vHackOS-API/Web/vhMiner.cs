using System.Threading.Tasks;
using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public sealed class vhMiner : vhClient<MinerResponse>
    {
        internal vhMiner() : base("mining.php")
        {
        }

        public MinerResponse StartMiner()
        {
            var req = CreateRequest();

            req.AddParam("action", "100");

            return Execute(req);
        }

        public async Task<MinerResponse> StartMinerAsync()
        {
            var req = CreateRequest();

            req.AddParam("action", "100");

            return await ExecuteAsync(req);
        }

        public MinerResponse Collect()
        {
            var req = CreateRequest();

            req.AddParam("action", "200");

            return Execute(req);
        }

        public async Task<MinerResponse> CollectAsync()
        {
            var req = CreateRequest();

            req.AddParam("action", "200");

            return await ExecuteAsync(req);
        }

        public MinerResponse AddGPU()
        {
            var req = CreateRequest();

            req.AddParam("action", "8888");

            return Execute(req);
        }
    }
}