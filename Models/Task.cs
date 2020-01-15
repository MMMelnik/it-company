using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_company.Models
{
    public enum Status {
        Done,
        InProgress,
        Denied,
        Expired,
        CloseToTheDeadline
    }

    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime DueTo { get; set; }
        public int AssignedToEmployeeId { get; set; }
        public int ProjectId { get; set; }
    }
}
