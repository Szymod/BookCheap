using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Persistence.Mappings
{
    public class TagMapping:  EntityTypeConfiguration<Tag>
    {
        public TagMapping()
        {
            HasKey(x => x.TagId);

            Property(x => x.Name).IsRequired().HasMaxLength(255);
        }
    }
}