using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeDictionary.DataAccess.Models
{
    public class TaskHistory
    {
        public Guid Id { get; set; }
        public Guid UserId {get; set;}
        public Guid TaskId { get; set; }
        public TimeSpan RecordedTime { get; set; }
        public string Notes { get; set; }
        public bool Outlier { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }

    }
}
