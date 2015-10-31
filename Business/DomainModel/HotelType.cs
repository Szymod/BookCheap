using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.DomainModel
{
    public class HotelType
    {
        public HotelType()
        {
            HotelsWithThisType = new List<Hotel>();
            ApplicationsWithThisType = new List<Application>();
        }

        public int HotelTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Hotel> HotelsWithThisType { get; set; }
        public virtual ICollection<Application> ApplicationsWithThisType { get; set; }
    }
}
