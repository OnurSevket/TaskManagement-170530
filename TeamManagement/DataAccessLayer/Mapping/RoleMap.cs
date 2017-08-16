using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccessLayer.Mapping
{
   public  class RoleMap:EntityTypeConfiguration<Role>
    {

        public RoleMap()
        {
            HasKey(r => r.ID);

            Property(r => r.Name)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

                
        }
    }
}
