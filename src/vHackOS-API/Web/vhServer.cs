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
    }
}