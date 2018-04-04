using System.Threading.Tasks;
using vHackOS.Cryptography;
using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public sealed class vhLogin : vhClient<LoginCredentials>
    {

        internal delegate void LoginDelegate(LoginCredentials credentials);
        internal event LoginDelegate OnLogin;

        internal vhLogin() : base("login.php")
        {
        }

        public LoginCredentials Login(string username, string password)
        {
            var request = CreateRequest();

            request.AddParam("username", username);
            request.AddParam("password", vhCrypto.GetMD5HashString(password));

            var result = Execute(request);

            OnLogin?.Invoke(result);

            return result;
        }

        public async Task<LoginCredentials> LoginAsync(string username, string password)
        {
            var request = CreateRequest();

            request.AddParam("username", username);
            request.AddParam("password", vhCrypto.GetMD5HashString(password));

            var result = await ExecuteAsync(request);

            OnLogin?.Invoke(result);

            return result;
        }
    }
}