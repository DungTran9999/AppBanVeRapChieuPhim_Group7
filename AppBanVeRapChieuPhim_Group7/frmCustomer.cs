using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanVeRapChieuPhim_Group7
{
    public partial class frmCustomer : Form
    {
        private static frmCustomer instance;
        public static frmCustomer GetInStance()
        {
            if (instance == null)
            {
                instance = new frmCustomer();
            }
            return instance;
        }
        public frmCustomer()
        {
            InitializeComponent();
        }
    }
}
