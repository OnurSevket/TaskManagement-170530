using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DataAccessLayer.Mapping
{
   public  class RequestMap: EntityTypeConfiguration<Request>
    {
        public RequestMap()
        {
            Property(r => r.Description)
                .HasMaxLength(400);

            HasRequired(r => r.Project)
                .WithMany(p => p.Requests)
                .HasForeignKey(r => r.ProjectId);


        }
    }
}
