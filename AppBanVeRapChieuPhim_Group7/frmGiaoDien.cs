﻿using System;
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
            lbChangeName.BackColor = Color.Transparent;
        }
        private Timer timer;
        private int currentPosition = 0;
        private const int speed = 4; // Tốc độ chạy của văn bản
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

        private void btnTicket_Click(object sender, EventArgs e)
        {
            plScroll.Height = btnTicket.Height;
            plScroll.Top = btnTicket.Top;
            plScroll.Left = btnTicket.Left;
            

            lbChangeName.Text = "Ticket";

            this.plLoadForm.Controls.Clear();

            frmTicket frmTicket_View = frmTicket.GetInStance();
            frmTicket_View.FormBorderStyle = FormBorderStyle.None;
            frmTicket_View.Dock = DockStyle.Fill;
            frmTicket_View.TopLevel = false;
            frmTicket_View.TopMost = true;

            this.plLoadForm.Controls.Add(frmTicket_View);
            frmTicket_View.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            plScroll.Height = btnCustomer.Height;
            plScroll.Top = btnCustomer.Top;
            plScroll.Left = btnCustomer.Left;


            lbChangeName.Text = "Customer";

            this.plLoadForm.Controls.Clear();

            frmCustomer frmCustomer_View = frmCustomer.GetInStance();
            frmCustomer_View.FormBorderStyle = FormBorderStyle.None;
            frmCustomer_View.Dock = DockStyle.Fill;
            frmCustomer_View.TopLevel = false;
            frmCustomer_View.TopMost = true;

            this.plLoadForm.Controls.Add(frmCustomer_View);
            frmCustomer_View.Show();
        }

        private void frmGiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thong bao", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void frmGiaoDien_Load(object sender, EventArgs e)
        {
            plScroll.Height = btnSell.Height;
            plScroll.Top = btnSell.Top;
            plScroll.Left = btnSell.Left;
            

            lbChangeName.Text = "Sell";
            this.plLoadForm.Controls.Clear();
            frmSell frmSell_View = new frmSell() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSell_View.FormBorderStyle = FormBorderStyle.None;
            this.plLoadForm.Controls.Add(frmSell_View);
            frmSell_View.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
