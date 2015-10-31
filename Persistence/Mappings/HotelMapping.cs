using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.Mappings
{
    public class HotelMapping: EntityTypeConfiguration<Hotel>
    {
        public HotelMapping()
        {
            HasKey(x => x.HotelId);

            Property(x => x.Name).IsRequired().HasMaxLength(255);
            Property(x => x.Description).IsRequired().IsMaxLength();
            Property(x => x.City).IsRequired().HasMaxLength(25);
            Property(x => x.Street).IsRequired().HasMaxLength(25);
            Property(x => x.ZipCode).IsRequired().HasMaxLength(6);
            Property(x => x.Number).IsRequired().HasMaxLength(5);
            Property(x => x.Nip).IsRequired();

            HasRequired(x => x.HotelType).WithMany(x => x.HotelsWithThisType).HasForeignKey(x => x.HotelTypeId);
            HasRequired(x => x.User).WithMany(x => x.UserHotels).HasForeignKey(x => x.UserId);
        }
    }
}