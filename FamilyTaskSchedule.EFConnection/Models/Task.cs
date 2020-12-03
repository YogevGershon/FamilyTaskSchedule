using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyTaskSchedule.EFConnection.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime TaskCreationTime { get; set; }
        public DateTime TaskStart { get; set; }
        public DateTime TaskEnd { get; set; }
        public bool IsCompleted { get; set; } = false;

    }
}
