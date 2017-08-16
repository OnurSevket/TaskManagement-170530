using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccessLayer.Mapping
{
    public class EmployeeMap: EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            Property(e => e.ID)
                     .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
                
                
            Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.LastName)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Mail)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Phone)
                .HasMaxLength(20)
                .IsRequired();

            HasRequired(e => e.Role)
                .WithMany(r => r.Employees)
                .HasForeignKey(e => e.RoleID);

            HasMany(e => e.Works)
                .WithMany(w => w.Employees)
                .Map(x => x.ToTable("EmployeeWork"));
            
        }
    }
}
