using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.DomainModel
{
    public class Room
    {
        public Room()
        {
            Reservations = new List<Reservation>();
            Attachments = new List<Attachment>();
        }

        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
    }
}
