using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Mapping
{
   public  class CustomerMap: EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(c => c.ID);

            Property(c => c.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(c => c.CompanyName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.ContactName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.ContactTitle)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();
            Property(c => c.Email)
                 .HasMaxLength(50)
                 .IsRequired();

            Property(c => c.City)
                .HasMaxLength(30)
                .HasColumnType("varchar")
                .IsRequired();

            Property(c => c.Address)
                .HasMaxLength(200)
                .HasColumnType("varchar")
                .IsRequired();


           


               




    }
    }
}
