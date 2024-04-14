using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AppBanVeRapChieuPhim_Group7
{
    public partial class frmLogin : Form
    {
        
        
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
            txtPassWord.Text=txtUserName.Text="";
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
            
            string[] imagePaths =
            {
                @".\Resources\rsz_1ironnn.png",
                @".\Resources\rsz_1spidermann.png",
                @".\Resources\rsz_captain_american.png",
                @".\Resources\rsz_1screenshot_2024-04-11_032607.png",
                @".\Resources\rsz_thorr.png",
                @".\Resources\fastandfurious.png",
                @".\Resources\Marvel Avengers1.jpg"

            };
            

            // Đảm bảo rằng chỉ số không vượt quá số lượng ảnh
            if (currentIndex >= imagePaths.Length)
            {
                currentIndex = 0; // Quay lại ảnh đầu tiên nếu đã hiển thị hết tất cả ảnh
            }
            string currentpath = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentpath)?.Parent?.FullName;
            string imagePath = Path.Combine(parentDirectory, imagePaths[currentIndex]);
            if (File.Exists(imagePath))
            {
                ptbAnh.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Xử lý khi tệp ảnh không tồn tại
                // Ví dụ: Hiển thị một hình ảnh mặc định hoặc không thực hiện gì cả
            }
            // Tăng chỉ số để hiển thị ảnh tiếp theo trong lần kích hoạt tiếp theo của Timer
            currentIndex++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        public void doianh2()
        {
            string My = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string c = @"source\repos\DungTran9999\AppBanVeRapChieuPhim_Group7\AppBanVeRapChieuPhim_Group7\Resources\";

            string appDataFolderPath = Path.Combine(My, c);

        }
        
    }
}
