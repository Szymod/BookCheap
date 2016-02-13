using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCheap.Busines.DomainModel;
using BookCheap.Persistence.DataAccess;

namespace BookCheap.Clients.DesktopClient
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        public string SessionKey;

        private void button1_Click(object sender, EventArgs e)
        {
            string _login = textBox1.Text;
            string _passwd = textBox2.Text;

            using (UnitOfWork u = new UnitOfWork())
            {
                var x = u.Users.GetAll().Where(a => a.Login == _login && a.Password == _passwd).FirstOrDefault();
                if (x.IsBlocked)
                {
                    MessageBox.Show("Twoje konto jest zablokowane.");
                }
                else
                {
                    WebService.SessionManager serv = new WebService.SessionManager();
                    SessionKey = serv.GetSession(_login, _passwd);
                }
            }         
        }   
    }
}
