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
    public partial class ReservationView : UserControl
    {
        Reservation r;
        public ReservationView(Reservation reservation)
        {
            InitializeComponent();
            this.lblData.Text = reservation.DateFrom + " - " + reservation.DateTo;
            this.lblRoom.Text = reservation.Room.Name;
            this.lblHotel.Text = reservation.Room.Hotel.Name;
            r = reservation;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            using (UnitOfWork u = new UnitOfWork())
            {
                r.Status = Reservation.StatusValue.Accepted;
                u.Reservations.Update(r);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            r.Status = Reservation.StatusValue.Canceled;
            u.Reservations.Update(r);

        }
    }
}
