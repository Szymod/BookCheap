using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.Mappings
{
    public class HotelTypeMapping :  EntityTypeConfiguration<HotelType>
    {
        public HotelTypeMapping()
        {
            HasKey(x => x.HotelTypeId);

            Property(x => x.Name).HasMaxLength(255);
        }
    }
}