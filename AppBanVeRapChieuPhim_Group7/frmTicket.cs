using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AppBanVeRapChieuPhim_Group7
{
    public partial class frmTicket : Form
    {
        private static frmTicket instance;
        public static frmTicket GetInStance()
        {
            if (instance == null)
            {
                instance = new frmTicket();
            }
            return instance;
        }

        public void RecieveData(string theater, string movie, string price, string time, string seats)
        {
            lbTheater.Text = theater;
            lbMovie.Text = movie;
            lbPrice.Text = price;
            lbTime.Text = time;
            lbSeats.Text = seats;

            DateTime gio = DateTime.Now;
            lbTimeBuy.Text = gio.ToString();

        }

        public frmTicket()
        {
            InitializeComponent();
        }


    }
}