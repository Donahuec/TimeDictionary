using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeDictionary.DataAccess.Models
{
    public class TimerTask
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? GroupId { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public TimeSpan AverageTime { get; set; }
        public EnergyLevel Energy { get; set; }
        public string Notes { get; set; }
        public string Icon { get; set; }
        public bool Favorite { get; set; }
        public int ListOrder { get; set; }
        public List<TaskHistory> History { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}

