using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Employee:IEntity
    {
        public Employee()
        {
            Projects = new HashSet<Project>();
            Works = new HashSet<Work>();
        }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual  ICollection<Work> Works { get; set; }

        public int RoleID { get; set; }

        public virtual Role Role { get; set; }

        [Required]
        public int LoginID { get; set; }

        [Required]
        public virtual Login Login { get; set; }

        public string FullName
        {
            get { return FirstName+LastName; } 
        }
        public override string ToString()
        {
            return FirstName + "   " + LastName;
        }


    }
}
