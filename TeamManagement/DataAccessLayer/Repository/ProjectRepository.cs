using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ProjectRepository : BaseRepository<Project>
    {
        public ProjectRepository(TaskManagementContext context) : base(context)
        {
        }

        //public override void Add(Project item)
        //{
        //    _context.Entry(item).State = System.Data.Entity.EntityState.Added;
        //    _context.Entry(item.Customer).State = System.Data.Entity.EntityState.Unchanged;

        //    foreach (Employee emp in item.Employees)
        //    {
        //        _context.Entry(emp).State = System.Data.Entity.EntityState.Unchanged;
        //    }

        //}

     
    }
}
