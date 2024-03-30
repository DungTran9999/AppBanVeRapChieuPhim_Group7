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
    public partial class frmGiaoDien : Form
    {
        public frmGiaoDien()
        {
            InitializeComponent();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            plScroll.Height = btnSell.Height;
            plScroll.Top = btnSell.Top;
            plScroll.Left = btnSell.Left;
            btnSell.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);

            lbChangeName.Text = "Sell";
            this.plLoadForm.Controls.Clear(); 
            frmSell frmSell_View = new frmSell() { Dock = DockStyle.Fill, TopLevel=false, TopMost= true };
            frmSell_View.FormBorderStyle = FormBorderStyle.None;
            this.plLoadForm.Controls.Add(frmSell_View);
            frmSell_View.Show();
        }


        private void btnManager_Click(object sender, EventArgs e)
        {
            plScroll.Height = btnManager.Height;
            plScroll.Top = btnManager.Top;
            plScroll.Left = btnManager.Left;
            btnManager.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);

            lbChangeName.Text = "Sell";
            this.plLoadForm.Controls.Clear();
            frmManager.Instance = new frmManager() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmManager.Instance.FormBorderStyle = FormBorderStyle.None;
            this.plLoadForm.Controls.Add(frmManager.Instance);
            frmManager.Instance.Show();
        }

        private void btnSell_Leave(object sender, EventArgs e)
        {
            btnSell.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
        }

        private void btnManager_Leave(object sender, EventArgs e)
        {
            btnManager.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ban co muon thoat khong?", "Thong bao", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmGiaoDien_Load(object sender, EventArgs e)
        {
            plScroll.Height = btnSell.Height;
            plScroll.Top = btnSell.Top;
            plScroll.Left = btnSell.Left;
            btnSell.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);

            lbChangeName.Text = "Sell";
            this.plLoadForm.Controls.Clear();
            frmSell frmSell_View = new frmSell() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSell_View.FormBorderStyle = FormBorderStyle.None;
            this.plLoadForm.Controls.Add(frmSell_View);
            frmSell_View.Show();
        }
    }
}
