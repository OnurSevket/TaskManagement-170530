using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public  class Request:IEntity
    {
        public int ID { get; set; }
        public int ProjectId { get; set; }
        public string   Type { get; set; }
        public string  Description { get; set; }
        public virtual Project  Project { get; set; }

    }
}
