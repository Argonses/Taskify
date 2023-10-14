namespace Taskify.Client.Services
{
    public interface ITaskService
    {
        List<Taskify.Shared.Task> Tasks { get; set; }
        Task GetAllTasks();
    }
}
