using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeDictionary.DataAccess.Models
{
    public class TaskGroup
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
