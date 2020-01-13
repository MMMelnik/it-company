using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace it_company.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public string HeadId { get; set; }
        //public virtual ICollection<User> Employees{ get; set; }

        //public Department()
        //{
        //    Employees = new List<User>();
        //}
    }
}
