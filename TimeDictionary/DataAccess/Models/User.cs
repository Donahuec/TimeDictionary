using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeDictionary.DataAccess.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }
}
