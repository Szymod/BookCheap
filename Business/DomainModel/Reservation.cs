﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCheap.Busines.DomainModel
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public StatusValue Status { get; set; }

        public enum StatusValue
        {
            Accepted, Canceled
        }
       
    }
}
