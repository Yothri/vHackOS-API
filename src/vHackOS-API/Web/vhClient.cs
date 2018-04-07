using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using vHackOS.Web.Exceptions;
using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public abstract class vhClient<T> : IDisposable where T : ResponseBase
    {
        private const string API_URL = "https://api.vhack.cc/mobile/15/";
        
        protected HttpClient Client { get; }
        
        public string Endpoint { get; }
        public LoginCredentials Credentials { get; private set; }

        protected vhClient(string endpoint)
        {
            Client = new HttpClient();
            Client.Timeout = new TimeSpan(0, 0, 10);

            Endpoint = endpoint;
        }

#if !DEBUG
        internal vhRequest CreateRequest()
#else
        public vhRequest CreateRequest()
#endif
        {
            var req = new vhRequest();

            if(Credentials != null)
            {
                req.AddParam("accesstoken", Credentials.AccessToken);
                req.AddParam("uid", Credentials.UserID.ToString());
            }

            return req;
        }

        internal void SetCredentials(LoginCredentials credentials)
        {
            Credentials = credentials;
        }

        internal async Task<T> ExecuteAsync(vhRequest request)
        {
            await Task.Delay(1000);

            var response = JsonConvert.DeserializeObject<T>(await Client?.GetStringAsync(API_URL + Endpoint + request.GetRequestPayload()));

            if (response.Result == "36")
                throw new UnauthorizedException("Invalid or missing authentication.");

            return response;
        }

#if DEBUG
        public virtual string ExecuteDebug(vhRequest request)
        {
            return Client?.GetStringAsync(API_URL + Endpoint + request.GetRequestPayload()).Result;
        }
#endif

        internal T Execute(vhRequest request)
        {
            Thread.Sleep(500);
            var req = WebRequest.Create(API_URL + Endpoint + request.GetRequestPayload());
            req.Proxy = null;
            
            var response = default(T);
            using (var res = req.GetResponse())
            using (var reader = new StreamReader(res.GetResponseStream()))
            {
                var str = reader.ReadToEnd();
                response = JsonConvert.DeserializeObject<T>(str);
            }

            if (response.Result == "36")
                throw new UnauthorizedException("Invalid or missing authentication credentials.");

            return response;
        }

        public virtual T Update()
        {
            return Execute(CreateRequest());
        }

        public virtual async Task<T> UpdateAsync()
        {
            return await ExecuteAsync(CreateRequest());
        }

        ~vhClient()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                Client?.Dispose();
        }
    }
}