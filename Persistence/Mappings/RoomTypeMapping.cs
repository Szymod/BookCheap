using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.Mappings
{
    public class RoomTypeMapping:  EntityTypeConfiguration<RoomType>
    {
        public RoomTypeMapping()
        {
            HasKey(x => x.RoomTypeId);

            Property(x => x.Name).IsRequired().HasMaxLength(255);
            Property(x => x.Capacity).IsRequired();
        }
    }
}