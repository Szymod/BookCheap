using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.DomainModel
{
    public class Hotel
    {
        public Hotel()
        {
            Rooms = new List<Room>();
            Attachments = new List<Attachment>();
            Tags = new List<Tag>();
            Comments = new List<Comment>();
        }

        public int HotelId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HotelTypeId { get; set; }
        public HotelType HotelType { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string Number { get; set; }
        public int Nip { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
