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

        public async Task<Taskify.Shared.Task> AddTask(Taskify.Shared.Task task)
        {
            var response = await _http.PostAsJsonAsync("api/Tasks", task);
            response.EnsureSuccessStatusCode();

            var addedTask = await response.Content.ReadFromJsonAsync<Taskify.Shared.Task>();
            Tasks.Add(addedTask);

            return addedTask;
        }

        public async Task<Taskify.Shared.Task> DeleteTask(int id)
        {
            var response = await _http.DeleteAsync($"api/Tasks/{id}");
            response.EnsureSuccessStatusCode();

            var deletedTask = Tasks.FirstOrDefault(t => t.Id == id);
            Tasks.Remove(deletedTask);

            return deletedTask;
        }

        public async Task GetAllTasks()
        {
            Tasks = await _http.GetFromJsonAsync<List<Taskify.Shared.Task>>("api/Tasks");
        }

        public async Task<Taskify.Shared.Task> GetTaskById(int id)
        {
            return await _http.GetFromJsonAsync<Taskify.Shared.Task>($"api/Tasks/{id}");
        }

        public async Task<Taskify.Shared.Task> UpdateTask(int id, Taskify.Shared.Task task)
        {
            var response = await _http.PutAsJsonAsync($"api/Tasks/{id}", task);
            response.EnsureSuccessStatusCode();

            var updatedTask = await response.Content.ReadFromJsonAsync<Taskify.Shared.Task>();
            var existingTask = Tasks.FirstOrDefault(t => t.Id == id);

            if (existingTask != null)
            {
                existingTask.Title = updatedTask.Title;
                existingTask.Description = updatedTask.Description;
                existingTask.Category = updatedTask.Category;
                existingTask.Status = updatedTask.Status;
                existingTask.AddedTime = updatedTask.AddedTime;
            }

            return existingTask;
        }
    }
}
