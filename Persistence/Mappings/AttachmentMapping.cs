using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.Mappings
{
    public class AttachmentMapping : EntityTypeConfiguration<Attachment>
    {
        public AttachmentMapping()
        {
            HasKey(x => x.AttachmentId);

            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.NameWithExtension).IsRequired().HasMaxLength(60);
            Property(x => x.Extension).IsRequired().HasMaxLength(10);
            Property(x => x.Content).IsRequired().IsMaxLength();

            HasOptional(x => x.Hotel).WithMany(x => x.Attachments).HasForeignKey(x => x.HotelId);
            HasOptional(x => x.Room).WithMany(x => x.Attachments).HasForeignKey(x => x.RoomId);
        }
    }
}
