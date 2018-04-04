using System.Threading.Tasks;
using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public sealed class vhStore : vhClient<StoreResponse>
    {
        internal vhStore() : base ("store.php")
        {
        }

        public StoreResponse AddTask(AppType appType)
        {
            var request = CreateRequest();

            request.AddParam("appcode", ((int)appType).ToString());
            request.AddParam("action", "100");

            return Execute(request);
        }

        public async Task<StoreResponse> AddTaskAsync(AppType appType)
        {
            var request = CreateRequest();

            request.AddParam("appcode", ((int)appType).ToString());
            request.AddParam("action", "100");

            return await ExecuteAsync(request);
        }

        public StoreResponse FillTasks(AppType appType)
        {
            var request = CreateRequest();

            request.AddParam("appcode", ((int)appType).ToString());
            request.AddParam("action", "5500");

            return Execute(request);
        }

        public async Task<StoreResponse> FillTasksAsync(AppType appType)
        {
            var request = CreateRequest();

            request.AddParam("appcode", ((int)appType).ToString());
            request.AddParam("action", "5500");

            return await ExecuteAsync(request);
        }
    }
}