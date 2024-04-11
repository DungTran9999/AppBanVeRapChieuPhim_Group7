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
    public partial class frmLogin : Form
    {
        private string[] imagePaths = 
        {
            @"C:\Users\ASUS\source\repos\DungTran9999\AppBanVeRapChieuPhim_Group7\AppBanVeRapChieuPhim_Group7\Resources\rsz_1ironnn.png",
            @"C:\Users\ASUS\source\repos\DungTran9999\AppBanVeRapChieuPhim_Group7\AppBanVeRapChieuPhim_Group7\Resources\rsz_1spidermann.png",
            @"C:\Users\ASUS\source\repos\DungTran9999\AppBanVeRapChieuPhim_Group7\AppBanVeRapChieuPhim_Group7\Resources\rsz_thorr.png",
            @"C:\Users\ASUS\source\repos\DungTran9999\AppBanVeRapChieuPhim_Group7\AppBanVeRapChieuPhim_Group7\Resources\harry login.png",
            @"C:\Users\ASUS\source\repos\DungTran9999\AppBanVeRapChieuPhim_Group7\AppBanVeRapChieuPhim_Group7\Resources\fastandfurious.png",
            @"C:\Users\ASUS\source\repos\DungTran9999\AppBanVeRapChieuPhim_Group7\AppBanVeRapChieuPhim_Group7\Resources\rsz_captain_american.png",
            @"C:\Users\ASUS\source\repos\DungTran9999\AppBanVeRapChieuPhim_Group7\AppBanVeRapChieuPhim_Group7\Resources\Marvel Avengers1.jpg"

        };
        private int currentIndex = 0;
        private Timer timer;
        public frmLogin()
        {
            InitializeComponent();
            txtPassWord.UseSystemPasswordChar = true;
            doianh();
        }
        public void doianh()
        {
            timer = new Timer();
            timer.Interval = 2000; // 2 giây
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(dangnhap()==false)
            {
              
            }

            else
            {
                frmGiaoDien f = new frmGiaoDien();
                this.Hide();
                txtPassWord.Text = txtUserName.Text = "";
                f.ShowDialog();
                this.Show();
            }
        }
        private bool dangnhap()
        {
            if (txtUserName.Text == "NhomD3T" && txtPassWord.Text == "11111")
            {
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG", "THÔNG BÁO");
                return true;
            }
            else if(txtUserName.Text == "a" && txtPassWord.Text == "a")
            {
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG", "THÔNG BÁO");
                return true;
            }
            else
            {
                MessageBox.Show("TÀI KHOẢN HOẶC MẬT KHẨU SAI, VUI LÒNG NHẬP LẠI", "THÔNG BÁO");
                return false;
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Không?", "THÔNG BÁO", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
            else
            {
                
                txtPassWord.UseSystemPasswordChar = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Đảm bảo rằng chỉ số không vượt quá số lượng ảnh
            if (currentIndex >= imagePaths.Length)
            {
                currentIndex = 0; // Quay lại ảnh đầu tiên nếu đã hiển thị hết tất cả ảnh
            }

            // Hiển thị ảnh tiếp theo trong PictureBox
            ptbAnh.Image = Image.FromFile(imagePaths[currentIndex]);

            // Tăng chỉ số để hiển thị ảnh tiếp theo trong lần kích hoạt tiếp theo của Timer
            currentIndex++;
        }
    }
}
