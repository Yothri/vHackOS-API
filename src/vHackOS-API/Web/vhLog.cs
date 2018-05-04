using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public class vhLog : vhClient<LogResponse>
    {
        internal vhLog() : base("log.php")
        { }

        public LogResponse SetLog(string log)
        {
            var req = CreateRequest();

            req.AddParam("action", "100");
            req.AddParam("log", log);

            var res = Execute(req);

            return res;
        }
    }
}