using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.Mappings
{
    public class CommentMapping: EntityTypeConfiguration<Comment>
    {
        public CommentMapping()
        {
            HasKey(x => x.CommentId);

            Property(x => x.Content).IsRequired().HasMaxLength(255);
            Property(x => x.AlimentationRating).IsRequired();
            Property(x => x.BathroomRating).IsRequired();
            Property(x => x.CompatibilityRating).IsRequired();
            Property(x => x.LocalizationRating).IsRequired();
            Property(x => x.QualityRating).IsRequired();
            Property(x => x.RoomRating).IsRequired();
            Property(x => x.RoomServiceRating).IsRequired();

            HasRequired(x => x.Hotel).WithMany(x => x.Comments).HasForeignKey(x => x.HotelId).WillCascadeOnDelete(false);
            HasRequired(x => x.User).WithMany(x => x.UserComments).HasForeignKey(x => x.UserId).WillCascadeOnDelete(false);
        }
    }
}
