using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Role:IEntity
    {
        public Role()
        {
            Employees = new HashSet<Employee>();
        }
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual  ICollection<Employee> Employees { get; set; }
    }
}
