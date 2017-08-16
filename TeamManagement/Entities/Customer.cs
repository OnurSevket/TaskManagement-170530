using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Customer : IEntity
    {

        public Customer()
        {
            Projects = new HashSet<Project>();
        }

        public int ID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

       

        public virtual  ICollection<Project> Projects { get; set; }

    }
}
