using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer.Mapping
{
    public class WorkMap:EntityTypeConfiguration<Work>
    {

        public WorkMap()
        {
            HasKey(w => w.ID);


            Property(w => w.Name)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();


            Property(w => w.Description)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

           
            Property(w => w.StartDate)
                .HasColumnType("datetime")
                .IsRequired();

            Property(w => w.EndDate)
                .HasColumnType("datetime")
                .IsRequired();

            HasRequired(w => w.Project)
                .WithMany()
                .HasForeignKey(w => w.ProjectID);

        }

    }
}
