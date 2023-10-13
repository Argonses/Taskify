
using Microsoft.EntityFrameworkCore;
using Taskify.Server.Data;

namespace Taskify.Server.Services
{
    public class TaskService : ITaskService
    {
        private readonly DataContext _context;

        public TaskService(DataContext context)
        {
            _context = context;
        }
        public async Task<Shared.Task> DeleteTask(int id)
        {
            if (_context.Tasks == null)
            {
                return null;
            }
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return null;
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return task;
        }

        public async Task<Shared.Task> GetTask(int id)
        {
            if (_context.Tasks == null)
            {
                return null;
            }
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
            {
                return null;
            }

            return task;
        }

        public async Task<List<Shared.Task>> GetTasks()
        {
            if (_context.Tasks == null)
            {
                return null;
            }
            return await _context.Tasks.ToListAsync();
        }

        public async Task<Shared.Task> PostTask(Shared.Task task)
        {
            if (_context.Tasks == null)
            {
                return null;
            }
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return task;
        }

        public async Task<Shared.Task> PutTask(int id, Shared.Task task)
        {
            if (id != task.Id)
            {
                return null;
            }

            _context.Entry(task).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return task;
        }

        public bool TaskExists(int id)
        {
            return (_context.Tasks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
