using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer.Mapping;
namespace DataAccessLayer
{
    public class TaskManagementContext:DbContext
    {

        public TaskManagementContext():base("alfa_neptune_ef_black_db")
        {
           
        }
        public virtual  DbSet<Project> Projects{ get; set; }

        public virtual  DbSet<Work> Works { get; set; }
        public  virtual  DbSet<Customer> Customers { get; set; }
        public virtual  DbSet<Employee> Employees { get; set; }
        public virtual  DbSet<Login> Logins { get; set; }
        public virtual  DbSet<Request> Requests { get; set; }
        public virtual  DbSet<Role> Roles { get; set; }
        public virtual  DbSet<State> States { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new WorkMap());
            modelBuilder.Configurations.Add(new RequestMap());
            


        }


    }
}
