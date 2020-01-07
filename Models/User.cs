using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace it_company.Models
{
    public enum Role
    {
        Employee,
        Pm,
        Admin
    }
    public class User 
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int PasswordHash { get; set; }
        public Role Role { get; set; }
        public int DepartmentId { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public User()
        {
            Tasks = new List<Task>();
        }
    }
}
