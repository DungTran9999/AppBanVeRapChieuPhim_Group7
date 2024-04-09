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
            automatic();
        }
        private Timer timer;
        private int currentPosition = 0;
        private const int speed = 10; // Tốc độ chạy của văn bản
        public void automatic()
        {
            timer = new Timer();
            timer.Interval = 50; // Đặt tần suất cập nhật (milliseconds)
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật vị trí của văn bản
            currentPosition += speed;
            if (currentPosition > this.Width)
            {
                currentPosition = -lb8.Width;
            }

            // Đặt vị trí mới cho văn bản
            lb8.Location = new System.Drawing.Point(currentPosition, lb8.Location.Y);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            plScroll.Height = btnSell.Height;
            plScroll.Top = btnSell.Top;
            plScroll.Left = btnSell.Left;
            btnSell.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);

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
            btnManager.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);

            lbChangeName.Text = "Manager";

            this.plLoadForm.Controls.Clear();

            frmManager frmManager_View = frmManager.GetInstance();
            frmManager_View.FormBorderStyle = FormBorderStyle.None;
            frmManager_View.Dock = DockStyle.Fill;
            frmManager_View.TopLevel = false;
            frmManager_View.TopMost = true;

            this.plLoadForm.Controls.Add(frmManager_View);
            frmManager_View.Show();
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            plScroll.Height = btnTicket.Height;
            plScroll.Top = btnTicket.Top;
            plScroll.Left = btnTicket.Left;
            btnTicket.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);

            lbChangeName.Text = "Setting";

            this.plLoadForm.Controls.Clear();

            frmBill frmSetting_View = frmBill.GetInStance();
            frmSetting_View.FormBorderStyle = FormBorderStyle.None;
            frmSetting_View.Dock = DockStyle.Fill;
            frmSetting_View.TopLevel = false;
            frmSetting_View.TopMost = true;

            this.plLoadForm.Controls.Add(frmSetting_View);
            frmSetting_View.Show();
        }

        private void btnSell_Leave(object sender, EventArgs e)
        {
            btnSell.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
        }

        private void btnManager_Leave(object sender, EventArgs e)
        {
            btnManager.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
        }

        private void btnSetting_Leave(object sender, EventArgs e)
        {
            btnTicket.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
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
            btnSell.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);

            lbChangeName.Text = "Sell";
            this.plLoadForm.Controls.Clear();
            frmSell frmSell_View = new frmSell() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSell_View.FormBorderStyle = FormBorderStyle.None;
            this.plLoadForm.Controls.Add(frmSell_View);
            frmSell_View.Show();
        }

        
    }
}
