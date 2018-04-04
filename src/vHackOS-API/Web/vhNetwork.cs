using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public sealed class vhNetwork : vhClient<NetworkResponse>
    {
        internal vhNetwork() : base("network.php")
        {
        }
    }
}