using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public class vhRemoteLog : vhClient<RemoteLogResponse>
    {
        internal vhRemoteLog() : base("remotelog.php")
        {
        }

        public RemoteLogResponse ClearLog(string targetIp)
        {
            var req = CreateRequest();

            req.AddParam("action", "100");
            req.AddParam("target", targetIp);
            req.AddParam("log", string.Empty);

            return Execute(req);
        }

        public RemoteLogResponse SetLog(string targetIp, string log)
        {
            var req = CreateRequest();

            req.AddParam("action", "100");
            req.AddParam("target", targetIp);
            req.AddParam("log", log);

            return Execute(req);
        }
    }
}