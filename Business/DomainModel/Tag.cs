using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.DomainModel
{
    public class Tag
    {
        public Tag()
        {
            HotelsWithThisTag = new List<Hotel>();
        }

        public int TagId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Hotel> HotelsWithThisTag { get; set; }
    }
}
