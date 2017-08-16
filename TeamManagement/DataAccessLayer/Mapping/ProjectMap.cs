using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Mapping
{
    public class ProjectMap: EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            HasKey(p => p.ID)
                .Property(x => x.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                .HasMaxLength(100).IsRequired();

            Property(p => p.Description)
                .HasMaxLength(400);

            Property(p => p.State)
                .HasMaxLength(50);

            HasRequired(p => p.Customer)
                .WithMany(c => c.Projects)
                .HasForeignKey(x => x.CustomerID);

            HasMany(p => p.Employees)
              .WithMany(e=>e.Projects)
              .Map(x=>x.ToTable("ProjectEmployee"));

            Property(p => p.RealEndDate)
                .IsOptional();
            Property(p => p.RealStartDate)
                .IsOptional();
            //TODO : Buraya Bakarlar

        }
    }
}
