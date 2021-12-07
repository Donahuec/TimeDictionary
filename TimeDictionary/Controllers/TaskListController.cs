using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeDictionary.DataAccess;
using TimeDictionary.DataAccess.Models;

namespace TimeDictionary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskListController : ControllerBase
    {
        private readonly ILogger<TaskListController> _logger;
        private TaskRepository _taskRepository;

        public TaskListController(TaskRepository taskRepository, ILogger<TaskListController> logger)
        {
            _logger = logger;
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<List<TimerTask>> Get()
        {

            var tasks = await _taskRepository.GetTasksAsync();
            
            return tasks;
        }
    }
}
