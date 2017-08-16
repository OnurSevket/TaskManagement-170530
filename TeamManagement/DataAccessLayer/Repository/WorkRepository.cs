using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccessLayer.Repository
{
    public class WorkRepository : BaseRepository<Work>
    {
        public WorkRepository(TaskManagementContext context) : base(context)
        {
        }
    }
}
