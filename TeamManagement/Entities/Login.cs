using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public  class Login:IEntity
    {
        [Key]
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
