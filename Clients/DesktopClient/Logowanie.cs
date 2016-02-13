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
                string msg;
                WebService.SessionManager serv = new WebService.SessionManager();
                msg = serv.GetSession(_login, _passwd);
                if(msg == "Twoje konto jest zablokowane")
                {
                    MessageBox.Show(msg);
                }
                else if (msg != null && msg != "Twoje konto jest zablokowane")
                {
                    SessionKey = msg;
                }
            }
        }
    }
}
