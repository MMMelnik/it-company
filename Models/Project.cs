using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace it_company.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public Project()
        {
            Tasks = new List<Task>();
        }
    }
}
