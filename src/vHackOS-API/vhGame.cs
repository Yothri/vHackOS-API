﻿using System;
using vHackOS.Web;
using vHackOS.Web.Model;

namespace vHackOS
{
    public sealed class vhGame : IDisposable
    {
        public static object QueryLockObj = new object();

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
        public vhBruteforce BruteforceEndpoint { get; }
        public vhRemoteBank RemoteBankEndpoint { get; }
        public vhMissions MissionsEndpoint { get; }
        public vhRemoteLog RemoteLogEndpoint { get; }
        public vhScan ScanEndpoint { get; }
        public vhSdk SdkEndpoint { get; }
        public vhLog LogEndpoint { get; }

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
            BruteforceEndpoint = new vhBruteforce();
            RemoteBankEndpoint = new vhRemoteBank();
            MissionsEndpoint = new vhMissions();
            RemoteLogEndpoint = new vhRemoteLog();
            ScanEndpoint = new vhScan();
            SdkEndpoint = new vhSdk();
            LogEndpoint = new vhLog();

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
            BruteforceEndpoint.SetCredentials(credentials);
            RemoteBankEndpoint.SetCredentials(credentials);
            MissionsEndpoint.SetCredentials(credentials);
            RemoteLogEndpoint.SetCredentials(credentials);
            ScanEndpoint.SetCredentials(credentials);
            SdkEndpoint.SetCredentials(credentials);
            LogEndpoint.SetCredentials(credentials);
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
                BruteforceEndpoint?.Dispose();
                RemoteBankEndpoint?.Dispose();
                MissionsEndpoint?.Dispose();
                RemoteLogEndpoint?.Dispose();
                ScanEndpoint?.Dispose();
                SdkEndpoint?.Dispose();
                LogEndpoint?.Dispose();
            }
        }
    }
}