using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public class vhMissions : vhClient<MissionsResponse>
    {
        internal vhMissions() : base("missions.php")
        {
        }

        public MissionsResponse ClaimDailyReward()
        {
            var req = CreateRequest();

            req.AddParam("action", "100");

            return Execute(req);
        }

        public MissionsResponse ClaimMissionReward(Mission mission)
        {
            var req = CreateRequest();

            req.AddParam("action", "200");
            req.AddParam("dailyid", ((int)(mission)).ToString());

            return Execute(req);
        }
    }

    public enum Mission
    {
        ExploitPlayer,
        FinishBruteforce,
        ClearRemoteLog,
        EmptyRemoteBank
    }
}