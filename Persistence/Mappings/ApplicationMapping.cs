using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using BookCheap.Busines.DomainModel;

namespace BookCheap.Persistence.Mappings
{
    public class ApplicationMapping : EntityTypeConfiguration<Application>
    {
        public ApplicationMapping()
        {
            HasKey(x => x.ApplicationId);

            Property(x => x.Name).IsRequired().HasMaxLength(255);
            Property(x => x.Description).IsRequired().HasMaxLength(500);
            Property(x => x.City).IsRequired().HasMaxLength(25);
            Property(x => x.Street).IsRequired().HasMaxLength(25);
            Property(x => x.ZipCode).IsRequired().HasMaxLength(6);
            Property(x => x.Number).IsRequired().HasMaxLength(5);
            Property(x => x.Nip).IsRequired();
            Property(x => x.ApplicationDate).IsRequired();

            HasRequired(x => x.HotelType).WithMany(x => x.ApplicationsWithThisType).HasForeignKey(x => x.HotelTypeId);
            HasRequired(x => x.User).WithMany(x => x.UserApplications).HasForeignKey(x => x.UserId);
        }
    }
}
