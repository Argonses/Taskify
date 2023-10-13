using Microsoft.EntityFrameworkCore;
using Taskify.Shared;

namespace Taskify.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Shared.Task> Tasks { get; set; }
    }
}
