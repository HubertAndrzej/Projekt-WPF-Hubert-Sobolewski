using System;
using System.Collections.Generic;

namespace WPFEmployeesTracker.Models
{
    public partial class TaskState
    {
        public TaskState()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string StateName { get; set; } = null!;

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
