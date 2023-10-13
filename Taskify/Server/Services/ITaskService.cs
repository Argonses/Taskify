namespace Taskify.Server.Services
{
    public interface ITaskService
    {
        Task<List<Shared.Task>> GetTasks();
        Task<Shared.Task> GetTask(int id);
        Task<Shared.Task> PutTask(int id, Shared.Task task);
        Task<Shared.Task> PostTask(Shared.Task task);
        Task<Shared.Task> DeleteTask(int id);
        bool TaskExists(int id);
    }
}
