using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public  class Work:IEntity
    {
        public Work()
        {
            Employees = new HashSet<Employee>();
        }
        public int ID { get; set; }
       
        public string  Name { get; set; }

        public string  Description { get; set; }

        public DateTime  StartDate { get; set; }

        public DateTime  EndDate { get; set; }

        public  virtual ICollection<Employee> Employees { get; set; }

        public int ProjectID { get; set; }

        public virtual Project Project { get; set; }

        public int StateID { get; set; }

        public State State { get; set; }
    }
}
