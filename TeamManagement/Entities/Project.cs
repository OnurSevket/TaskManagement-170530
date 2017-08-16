using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public  class Project:IEntity
    {
        public Project()
        {
            Employees = new HashSet<Employee>();
            Requests = new HashSet<Request>();
        }
        public int ID { get; set; }
        public string  Name { get; set; }
        public string  Description { get; set; }
        public DateTime  PlannedStartDate { get; set; }
        public DateTime  PlannedEndDate { get; set; }
        public string  State { get; set; }
        public DateTime? RealStartDate { get; set; }
        public DateTime?  RealEndDate { get; set; }
        public int?  CustomerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Request> Requests { get; set; }

    }
}
