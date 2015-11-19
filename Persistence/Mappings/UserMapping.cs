using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.Mappings
{
    public class UserMapping:  EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(x => x.UserId);

            Property(x => x.Firstname).IsRequired().HasMaxLength(255);
            Property(x => x.Lastname).IsRequired().HasMaxLength(255);
            Property(x => x.Login).IsRequired().HasMaxLength(25);
            Property(x => x.Password).IsRequired().HasMaxLength(64);
            Property(x => x.Email).IsRequired().HasMaxLength(40);
            Property(x => x.Phone).IsRequired().HasMaxLength(12);
            Property(x => x.IsAdmin).IsRequired();
            Ignore(x => x.IsOwner);
        }
    }
}