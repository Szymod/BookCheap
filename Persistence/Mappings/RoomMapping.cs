using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.Mappings
{
    public class RoomMapping:  EntityTypeConfiguration<Room>
    {
        public RoomMapping()
        {
            HasKey(x => x.RoomId);

            Property(x => x.Name).IsRequired().HasMaxLength(255);
            Property(x => x.Description).HasMaxLength(500);
            Property(x => x.Price).IsRequired().HasPrecision(15, 5);

            HasRequired(x => x.Hotel).WithMany(x => x.Rooms).HasForeignKey(x => x.HotelId);
            HasRequired(x => x.RoomType).WithMany(x => x.RoomsWithThisType).HasForeignKey(x => x.RoomTypeId);
        }
    }
}