using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public sealed class vhNetwork : vhClient<NetworkResponse>
    {
        internal vhNetwork() : base("network.php")
        {
        }

        public NetworkResponse AddAntivirusNode()
        {
            var req = CreateRequest();

            req.AddParam("action", "100");

            var res = Execute(req);

            return res;
        }

        public NetworkResponse AddFirewallNode()
        {
            var req = CreateRequest();

            req.AddParam("action", "200");

            var res = Execute(req);

            return res;
        }

        public NetworkResponse UpgradeSingleNode(NodeType nodeType, int nodeNumber)
        {
            var req = CreateRequest();

            req.AddParam("action", "500");
            req.AddParam("node_type", ((int)nodeType).ToString());
            req.AddParam("node_number", nodeNumber.ToString());

            var res = Execute(req);

            return res;
        }

        public NetworkResponse UpgradeX5Node(NodeType nodeType, int nodeNumber)
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