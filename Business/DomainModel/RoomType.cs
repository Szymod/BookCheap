using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.DomainModel
{
    public class RoomType
    {
        public RoomType()
        {
            RoomsWithThisType = new List<Room>();
        }

        public int RoomTypeId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<Room> RoomsWithThisType { get; set; }
    }
}
