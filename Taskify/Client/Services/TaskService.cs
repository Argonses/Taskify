using System.Net.Http.Json;

namespace Taskify.Client.Services
{
    public class TaskService : ITaskService
    {
        private readonly HttpClient _http;

        public TaskService(HttpClient http)
        {
            _http = http;
        }

        public List<Taskify.Shared.Task> Tasks { get; set; } = new List<Taskify.Shared.Task>();

        public async System.Threading.Tasks.Task GetAllTasks()
        {
            var result = await _http.GetFromJsonAsync<List<Taskify.Shared.Task>>("api/Tasks");
            if (result != null)
            {
                Tasks = result;
            }
        }
    }
}
