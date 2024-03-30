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
    public partial class frmSell : Form
    {
        public frmSell()
        {
            InitializeComponent();
        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            this.plLoadForm.Controls.Clear();
            frmTheater1 frmTheater1_View = new frmTheater1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTheater1_View.FormBorderStyle = FormBorderStyle.None;
            this.plLoadForm.Controls.Add(frmTheater1_View);
            frmTheater1_View.Show();
        }

        private void btnTheater1_Click(object sender, EventArgs e)
        {
           
            this.plLoadForm.Controls.Clear();
            frmTheater1 frmTheater1_View = new frmTheater1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTheater1_View.FormBorderStyle = FormBorderStyle.None;
            this.plLoadForm.Controls.Add(frmTheater1_View);
            frmTheater1_View.Show();
        }

        private void btnTheater2_Click(object sender, EventArgs e)
        {
            this.plLoadForm.Controls.Clear();
            frmTheater2 frmTheater2_View = new frmTheater2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTheater2_View.FormBorderStyle = FormBorderStyle.None;
            this.plLoadForm.Controls.Add(frmTheater2_View);
            frmTheater2_View.Show();
        }
    }
}
