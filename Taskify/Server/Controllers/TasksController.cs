using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Taskify.Server.Data;
using Taskify.Server.Services;
using Taskify.Shared;

namespace Taskify.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _service;

        public TasksController(ITaskService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Shared.Task>> GetTasks()
        {
          return await _service.GetTasks();
        }

        [HttpGet("{id}")]
        public async Task<Shared.Task> GetTask(int id)
        {
          return await _service.GetTask(id);
        }

        [HttpPut("{id}")]
        public async Task<Shared.Task> PutTask(int id, Shared.Task task)
        {
            return await _service.PutTask(id, task);
        }

        [HttpPost]
        public async Task<Shared.Task> PostTask(Shared.Task task)
        {
          return await _service.PostTask(task);
        }

        [HttpDelete("{id}")]
        public async Task<Shared.Task> DeleteTask(int id)
        {
            return await _service.DeleteTask(id);   
        }

        private bool TaskExists(int id)
        {
            return _service.TaskExists(id);
        }
    }
}
