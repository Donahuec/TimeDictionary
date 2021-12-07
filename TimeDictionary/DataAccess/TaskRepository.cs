using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeDictionary.DataAccess.Models;

namespace TimeDictionary.DataAccess
{
    public class TaskRepository
    {
        private readonly ILogger<TaskRepository> _logger;
        private MySqlConnection _connection;

        public TaskRepository(MySqlConnection connection, ILogger<TaskRepository> logger)
        {
            _logger = logger;
            _connection = connection;
        }

        public async Task<List<TimerTask>> GetTasksAsync()
        {
            var result = new List<TimerTask>();

            using (_connection)
            {
                _connection.Open();
                using var task_command = new MySqlCommand("select * from task;", _connection);
                using var task_reader = await task_command.ExecuteReaderAsync();
                while (await task_reader.ReadAsync())
                {
                    var task_result = new TimerTask()
                    {
                        Id = task_reader.GetFieldValue<Guid>(task_reader.GetOrdinal("_id")),
                        UserId = task_reader.GetFieldValue<Guid>(task_reader.GetOrdinal("user_id")),
                        GroupId = task_reader.GetFieldValue<Guid>(task_reader.GetOrdinal("group_id")),
                        Name = task_reader.GetFieldValue<string>(task_reader.GetOrdinal("task_name")),
                        AverageTime = task_reader.GetFieldValue<TimeSpan>(task_reader.GetOrdinal("average_time")),
                        Energy = (EnergyLevel)Enum.Parse(typeof(EnergyLevel), task_reader.GetFieldValue<int>(task_reader.GetOrdinal("energy")).ToString()),
                        Notes = task_reader.GetFieldValue<string>(task_reader.GetOrdinal("notes")),
                        Icon = task_reader.GetFieldValue<string>(task_reader.GetOrdinal("icon")),
                        Favorite = task_reader.GetFieldValue<bool>(task_reader.GetOrdinal("favorite")),
                        ListOrder = task_reader.GetFieldValue<int>(task_reader.GetOrdinal("list_order")),
                        CreateDate = task_reader.GetFieldValue<DateTime>(task_reader.GetOrdinal("created_date")),
                        EditDate = task_reader.GetFieldValue<DateTime>(task_reader.GetOrdinal("edited_date"))
                    };
                    result.Add(task_result);
                }

                
                foreach (var task_result in result)
                {
                    if (task_result.GroupId != null)
                    {
                        using var group_command = new MySqlCommand($"select group_name from task_group where _id like '{task_result.GroupId}';", _connection);
                        task_result.GroupName = group_command.ExecuteScalar().ToString();
                    }
                    // Get task history
                    // get tags
                }

            }
            
            return result;
        }
    }
}
