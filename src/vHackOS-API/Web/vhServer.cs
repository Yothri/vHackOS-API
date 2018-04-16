using System.Threading.Tasks;
using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public sealed class vhServer : vhClient<ServerResponse>
    {
        internal vhServer() : base("server.php")
        {
        }

        public ServerResponse OpenAllPackages()
        {
            var req = CreateRequest();

            req.AddParam("action", "2000");

            return Execute(req);
        }

        public async Task<ServerResponse> OpenAllPackagesAsync()
        {
            var req = CreateRequest();

            req.AddParam("action", "2000");

            return await ExecuteAsync(req);
        }

        public ServerResponse AddAntivirusNode()
        {
            var req = CreateRequest();

            req.AddParam("action", "100");

            var res = Execute(req);

            return res;
        }

        public ServerResponse AddFirewallNode()
        {
            var req = CreateRequest();

            req.AddParam("action", "200");

            var res = Execute(req);

            return res;
        }

        public ServerResponse UpgradeSingleNode(NodeType nodeType, int nodeNumber)
        {
            var req = CreateRequest();

            req.AddParam("action", "500");
            req.AddParam("node_type", ((int)nodeType).ToString());
            req.AddParam("node_number", nodeNumber.ToString());

            var res = Execute(req);

            return res;
        }

        public ServerResponse UpgradeX5Node(NodeType nodeType, int nodeNumber)
        {
            var req = CreateRequest();

            req.AddParam("action", "600");
            req.AddParam("node_type", ((int)nodeType).ToString());
            req.AddParam("node_number", nodeNumber.ToString());

            var res = Execute(req);

            return res;
        }
    }
}