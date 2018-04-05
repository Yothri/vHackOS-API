using System.Threading.Tasks;
using vHackOS.Web.Model;

namespace vHackOS.Web
{
    public sealed class vhTasks : vhClient<TasksResponse>
    {
        internal vhTasks() : base("tasks.php")
        {
        }

        public TasksResponse FinishUpdate(Update update)
        {
            var req = CreateRequest();

            req.AddParam("action", "200");
            req.AddParam("updateid", update.Id.ToString());

            return Execute(req);
        }

        public async Task<TasksResponse> FinishUpdateAsync(Update update)
        {
            var req = CreateRequest();

            req.AddParam("action", "200");
            req.AddParam("updateid", update.Id.ToString());

            return await ExecuteAsync(req);
        }

        public TasksResponse FinishUpdates(Update update)
        {
            var req = CreateRequest();

            req.AddParam("action", "500");
            req.AddParam("updateid", update.Id.ToString());

            return Execute(req);
        }

        public async Task<TasksResponse> FinishUpdatesAsync(Update update)
        {
            var req = CreateRequest();

            req.AddParam("action", "500");
            req.AddParam("updateid", update.Id.ToString());

            return await ExecuteAsync(req);
        }

        public TasksResponse BoostUpdates(Update update)
        {
            var req = CreateRequest();

            req.AddParam("action", "888");
            req.AddParam("updateid", update.Id.ToString());

            return Execute(req);
        }

        public async Task<TasksResponse> BoostUpdatesAsync(Update update)
        {
            var req = CreateRequest();

            req.AddParam("action", "888");
            req.AddParam("updateid", update.Id.ToString());

            return await ExecuteAsync(req);
        }
    }
}