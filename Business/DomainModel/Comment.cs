using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.DomainModel
{
    public class Comment
    {
        public Comment()
        {

        }

        public int CommentId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public string Content { get; set; }
        public short RoomRating { get; set; }
        public short BathroomRating { get; set; }
        public short RoomServiceRating { get; set; }
        public short AlimentationRating { get; set; }
        public short LocalizationRating { get; set; }
        public short QualityRating { get; set; }
        public short CompatibilityRating { get; set; }
    }
}
