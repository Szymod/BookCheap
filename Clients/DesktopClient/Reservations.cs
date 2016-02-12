using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCheap.Busines.Interfaces;
using BookCheap.Busines.DomainModel;
using BookCheap.Persistence.DataAccess;


namespace BookCheap.Clients.DesktopClient
{
    public partial class Reservations : UserControl
    {
        public Reservations(User user)
        {
            InitializeComponent();
            List<int> userRooms = new List<int>();
            using (UnitOfWork u = new UnitOfWork())
            {
                foreach (Hotel hotel in user.UserHotels)
                    foreach (Room room in hotel.Rooms)
                        userRooms.Add(room.RoomId);

               var x = u.Reservations.GetAll();
                foreach (Reservation r in x)
                {
                    if (userRooms.Contains(r.RoomId))
                    {
                        ReservationView rv = new ReservationView(r);
                        this.tableLayoutPanel1.Controls.Add(rv);
                    }
                }
            }
        }
    }
}
