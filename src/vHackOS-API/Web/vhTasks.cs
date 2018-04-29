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

        public TasksResponse BoostUpdatesX5(Update update)
        {
            var req = CreateRequest();

            req.AddParam("action", "8888");
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

        public TasksResponse RemoveBruteforce(Brute brute)
        {
            var req = CreateRequest();

            req.AddParam("action", "10000");
            req.AddParam("updateid", brute.Id);

            return Execute(req);
        }
    }
}