using System;
using vHackOS.Web;
using vHackOS.Web.Model;

namespace vHackOS
{
    public sealed class vhGame : IDisposable
    {
        public vhLogin LoginEndpoint { get; }
        public vhProfile ProfileEndpoint { get; }
        public vhServer ServerEndpoint { get; }
        public vhTasks TasksEndpoint { get; }
        public vhStore AppStoreEndpoint { get; }
        public vhMiner MiningEndpoint { get; }
        public vhUpdate UpdateEndpoint { get; }
        public vhMalwareKit MalwareKitEndpoint { get; }
        public vhNetwork NetworkEndpoint { get; }
        public vhExploit ExploitEndpoint { get; }

        public vhGame()
        {
            LoginEndpoint = new vhLogin();
            ProfileEndpoint = new vhProfile();
            ServerEndpoint = new vhServer();
            TasksEndpoint = new vhTasks();
            AppStoreEndpoint = new vhStore();
            MiningEndpoint = new vhMiner();
            UpdateEndpoint = new vhUpdate();
            MalwareKitEndpoint = new vhMalwareKit();
            NetworkEndpoint = new vhNetwork();
            ExploitEndpoint = new vhExploit();

            LoginEndpoint.OnLogin += LoginEndpoint_OnLogin;
        }

        public void SetCredentials(LoginCredentials credentials)
        {
            LoginEndpoint_OnLogin(credentials);
        }

        private void LoginEndpoint_OnLogin(Web.Model.LoginCredentials credentials)
        {
            ProfileEndpoint.SetCredentials(credentials);
            ServerEndpoint.SetCredentials(credentials);
            TasksEndpoint.SetCredentials(credentials);
            AppStoreEndpoint.SetCredentials(credentials);
            MiningEndpoint.SetCredentials(credentials);
            UpdateEndpoint.SetCredentials(credentials);
            MalwareKitEndpoint.SetCredentials(credentials);
            NetworkEndpoint.SetCredentials(credentials);
            ExploitEndpoint.SetCredentials(credentials);
        }

        ~vhGame()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                LoginEndpoint?.Dispose();
                ProfileEndpoint?.Dispose();
                ServerEndpoint?.Dispose();
                TasksEndpoint?.Dispose();
                AppStoreEndpoint?.Dispose();
                MiningEndpoint?.Dispose();
                UpdateEndpoint?.Dispose();
                MalwareKitEndpoint?.Dispose();
                NetworkEndpoint?.Dispose();
                ExploitEndpoint?.Dispose();
            }
        }
    }
}