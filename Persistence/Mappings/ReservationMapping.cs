using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.Mappings
{
    public class ReservationMapping:  EntityTypeConfiguration<Reservation>
    {
        public ReservationMapping()
        {
            HasKey(x => x.ReservationId);

            Property(x => x.DateFrom).IsRequired();
            Property(x => x.DateTo).IsRequired();

            HasRequired(x => x.Room).WithMany(x => x.Reservations).HasForeignKey(x => x.RoomId).WillCascadeOnDelete(false);
            HasRequired(x => x.User).WithMany(x => x.UserReservations).HasForeignKey(x => x.UserId).WillCascadeOnDelete(false);
        }
    }
}