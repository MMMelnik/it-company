using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using it_company.ViewModels;

namespace it_company.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        
        public virtual ICollection<User> Users { get; set; }
        public Department()
        {
            Users = new List<User>();
        }
        //public int HeadId { get; set; }
        //public User Head { get; set; }
    }
}
