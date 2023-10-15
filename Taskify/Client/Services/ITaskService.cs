namespace Taskify.Client.Services
{
    public interface ITaskService
    {
        List<Taskify.Shared.Task> Tasks { get; set; }
        Task<List<Taskify.Shared.Task>> GetAllTasks();
        Task<Taskify.Shared.Task> GetTaskById(int id);
        Task<Taskify.Shared.Task> AddTask(Taskify.Shared.Task task);
        Task<Taskify.Shared.Task> UpdateTask(int id, Taskify.Shared.Task task);
        Task<Taskify.Shared.Task> DeleteTask(int id);
    }
}
