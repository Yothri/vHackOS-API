using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public sealed class vhUpdate : vhClient<UpdateResponse>
    {
        internal vhUpdate() : base("update.php")
        {
        }

        public override UpdateResponse Update()
        {
            var req = CreateRequest();

            req.AddParam("lastread", "0");
            req.AddParam("notify", "0");

            return Execute(req);
        }
    }
}