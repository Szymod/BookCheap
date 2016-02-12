using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Helpers;

namespace BookCheap.Busines.DomainModel
{
    public class User
    {
        public User()
        {
            UserApplications = new List<Application>();
            UserComments = new List<Comment>();
            UserHotels = new List<Hotel>();
            UserReservations = new List<Reservation>();
        }

        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsOwner { get { return UserHotels.Count > 0; } private set {} }
        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set; }

        public virtual ICollection<Application> UserApplications { get; set; }
        public virtual ICollection<Comment> UserComments { get; set; }
        public virtual ICollection<Hotel> UserHotels { get; set; }
        public virtual ICollection<Reservation> UserReservations { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }

        public void SetPassword(string password)
        {
           // Password = Crypto.Hash(password);
        }
    }
}
