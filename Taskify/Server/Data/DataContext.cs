using Microsoft.EntityFrameworkCore;
using Taskify.Shared;

namespace Taskify.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Shared.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shared.Task>().HasData(
                new Shared.Task
                {
                    Id = 1,
                    Title = "Complete Project Presentation",
                    Description = "Prepare slides and rehearse for the project presentation.",
                    Category = TaskCategory.Work,
                    Status = Shared.TaskStatus.ToDo,
                    AddedTime = DateTime.Now
                },
                new Shared.Task
                {
                    Id = 2,
                    Title = "Go for a Run",
                    Description = "Enjoy a 30-minute jog in the park.",
                    Category = TaskCategory.Health,
                    Status = Shared.TaskStatus.InProgress,
                    AddedTime = DateTime.Now.AddDays(-1)
                },
                new Shared.Task
                {
                    Id = 3,
                    Title = "Read Chapter 3 of 'Machine Learning Fundamentals'",
                    Description = "Study and take notes on chapter 3 of the machine learning book.",
                    Category = TaskCategory.Study,
                    Status = Shared.TaskStatus.Done,
                    AddedTime = DateTime.Now.AddDays(-2)
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
