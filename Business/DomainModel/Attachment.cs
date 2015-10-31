using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.DomainModel
{
    public class Attachment
    {
        public Attachment()
        {

        }

        public int AttachmentId { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string NameWithExtension { get; set; }
        public byte[] Content { get; set; }
        public int? HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int? RoomId { get; set; }
        public Room Room { get; set; }
    }
}
