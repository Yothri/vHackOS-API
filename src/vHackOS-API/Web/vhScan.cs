using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public class vhScan : vhClient<ScanResponse>
    {
        internal vhScan() : base("scan.php")
        {
        }

        public ScanResponse Scan(string target)
        {
            var req = CreateRequest();

            req.AddParam("ipaddress", target);

            var result = Execute(req);

            return result;
        }
    }
}