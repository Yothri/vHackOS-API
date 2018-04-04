using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public sealed class vhProfile : vhClient<ProfileResponse>
    {
        internal vhProfile() : base("profile.php")
        {
        }
    }
}