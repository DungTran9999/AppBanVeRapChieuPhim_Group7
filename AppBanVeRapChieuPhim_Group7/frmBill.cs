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

namespace AppBanVeRapChieuPhim_Group7
{
    public partial class frmBill : Form
    {
        private static frmBill instance;
        public static frmBill GetInStance()
        {
            if (instance == null)
            {
                instance = new frmBill();
            }
            return instance;
        }
        
        public void RecieveData(string theater, string movie, string price, string time,string seats)
        {
            lbTheater.Text = theater;
            lbMovie.Text = movie;
            lbPrice.Text = price;
            lbTime.Text = time;
            lbSeats.Text = seats;

            DateTime gio= DateTime.Now;
            lbTimeBuy.Text = gio.ToString();

        }
       
        public frmBill()
        {
            InitializeComponent();
        }

       
    }
}
