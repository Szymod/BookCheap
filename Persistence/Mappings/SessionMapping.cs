using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using BookCheap.Busines.DomainModel;

namespace BookCheap.Persistence.Mappings
{
    class SessionMapping :EntityTypeConfiguration<Session>
    {
        public SessionMapping()
        {
            HasKey(x => x.SessionId);

            Property(x => x.Key).IsRequired().HasMaxLength(255);
            Property(x => x.ExpirationDate).IsRequired();

            HasRequired(x => x.User).WithMany(x => x.Sessions).HasForeignKey(x => x.UserId);
        }


        public int UserId { get; set; }
        public int SessionID { get; set; }
        public string Key { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}
