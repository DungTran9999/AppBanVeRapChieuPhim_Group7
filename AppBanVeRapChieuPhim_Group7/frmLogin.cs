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
        public frmLogin()
        {
            InitializeComponent();
            txtPassWord.UseSystemPasswordChar = true;
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

                f.ShowDialog();
                this.Show();
            }
        }
        private bool dangnhap()
        {
            if (txtUserName.Text == "NhomD3T" && txtPassWord.Text == "11111")
            {
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG", "THONG BÁO");
                return true;
            }
            else if(txtUserName.Text == "a" && txtPassWord.Text == "a")
            {
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG", "THONG BÁO");
                return true;
            }
            else
            {
                MessageBox.Show("ĐĂNG NHẬP THẤT BẠI", "THONG BÁO");
                return false;
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ban co muon thoat khong?", "Thong bao", MessageBoxButtons.OKCancel) != DialogResult.OK)
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
    }
}
