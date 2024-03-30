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
        public delegate void ClearData();
        public ClearData ClearChair;

        public event Action FormSellEvent;
       
        

        public frmSell()
        {
            InitializeComponent();
          
        }
        public void CountChair()
        {
            string chair = txtDataChair.Text;
            
            string[] soghe= chair.Split(',');
            int a = soghe.Length;
            lbNumberOfChair.Text= a.ToString();
            
        }

       
        private void frmSell_Load(object sender, EventArgs e)
        {
            


        }

        public void chooseFilm()
        {
            string movie = cbbMovie.Text;

            if (movie == "Tấm Cám Phiêu Lưu Ký")
            {
                txtPrice.Text = "100000";
                txtTime.Text = "14h";
            }
            else if (movie == "Ba Chú Heo")
            {
                txtPrice.Text = "120000";
                txtTime.Text = "17h";
            }
            else if (movie == "Báo Hồng")
            {
                txtPrice.Text = "150000";
                txtTime.Text = "9h";
            }
            else if (movie == "Điệp Viên 069")
            {
                txtPrice.Text = "110000";
                txtTime.Text = "22h";
            }
        }


        private void btnTheater1_Click(object sender, EventArgs e)
        {
           
            this.plLoadForm.Controls.Clear();
            frmTheater1 frmTheater1_View = new frmTheater1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTheater1_View.FormBorderStyle = FormBorderStyle.None;
           
            FormSellEvent += frmTheater1_View.OnFormSellEventReceived;

            frmTheater1_View.truyenData += LoadData;
            frmTheater1_View.truyenghe += LoadGhe;


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
        public void LoadGhe(int data)
        {
            lbNumberOfChair.Text= data.ToString();
        }
        public void LoadData(List<string> data)
        {
            
            txtDataChair.Text = "";
            txtDataChair.Text = string.Join(",", data);

        }

        private void cbbMovie_SelectedValueChanged(object sender, EventArgs e)
        {
            chooseFilm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            if(ClearChair != null)
            {
                ClearChair();
            }
            Clear();
            FormSellEvent?.Invoke();
        }
        public void Clear()
        {
            txtTime.Text = txtPrice.Text = "";
            cbbMovie.SelectedIndex = -1;
            txtDataChair.Text = "";
            lbNumberOfChair.Text = "0";
        }
    }
}
