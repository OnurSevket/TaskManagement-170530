using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccessLayer.Mapping
{
    public class LoginMap: EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            Property(l => l.UserName)
                .HasMaxLength(60).IsRequired();

            Property(l => l.Password)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
