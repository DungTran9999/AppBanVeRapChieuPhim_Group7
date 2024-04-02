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
        

        

        public event Action FormSellEvent;
        public event Action FormSellEvent2;
        public int soluong;
        public int totalmoney;


        public frmSell()
        {
            InitializeComponent();
        }
      

        List<Film> listItem;
        private void frmSell_Load(object sender, EventArgs e)
        {
            
            listItem = new List<Film>()
            {
                new Film(){Movie = "Ba Con Heo", Price = 99000,  Time = "9h30 - 11h"},
                new Film(){Movie = "Báo Hồng", Price = 110000,  Time = "17h - 19h"},
                
                new Film(){Movie = "Tấm cám phiêu lưu kí", Price = 125000,  Time = "19h - 20h30"}
            };
            cbbMovie.DataSource = listItem;
            cbbMovie.DisplayMember = "Movie";
        }

        public void chooseFilm(object sender)
        {
            //tạo biến cb từ sender ép kiểu qua combox
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Film data = cb.SelectedValue as Film;

               

                txtPrice.Text = data.Price.ToString();
                txtTime.Text = data.Time.ToString();
            }


            
        }
        public void openTheater()
        {
            string checkFilm = cbbMovie.Text;
            if(checkFilm =="Ba Con Heo")
            {
                this.plLoadForm.Controls.Clear();
                frmTheater1 frmTheater1_View = frmTheater1.GetInStance();
                frmTheater1_View.Dock = DockStyle.Fill;
                frmTheater1_View.TopLevel = false;
                frmTheater1_View.TopMost = true;
                frmTheater1_View.FormBorderStyle = FormBorderStyle.None;

                FormSellEvent += frmTheater1_View.OnFormSellEventReceived;

                frmTheater1_View.truyenData += LoadData;
                frmTheater1_View.truyenghe += LoadGhe;
                int a = frmTheater1_View.soluong;

                lbTheater.Text = "THEATER 1";
                this.plLoadForm.Controls.Add(frmTheater1_View);
                frmTheater1_View.Show();
            }   
            else if(checkFilm == "Tấm cám phiêu lưu kí")
            {
                this.plLoadForm.Controls.Clear();
                frmTheater2 frmTheater2_View = frmTheater2.GetInStance();
                frmTheater2_View.Dock = DockStyle.Fill;
                frmTheater2_View.TopLevel = false;
                frmTheater2_View.TopMost = true;
                frmTheater2_View.FormBorderStyle = FormBorderStyle.None;

                frmTheater2_View.truyenData2 += LoadData;
                frmTheater2_View.truyenghe2 += LoadGhe;

                lbTheater.Text = "THEATER 2";
                this.plLoadForm.Controls.Add(frmTheater2_View);
                frmTheater2_View.Show();
            }
            else if (checkFilm == "Báo Hồng")
            {
                this.plLoadForm.Controls.Clear();
                frmTheater3 frmTheater3_View = frmTheater3.GetInStance();
                frmTheater3_View.Dock = DockStyle.Fill;
                frmTheater3_View.TopLevel = false;
                frmTheater3_View.TopMost = true;
                frmTheater3_View.FormBorderStyle = FormBorderStyle.None;

               //

                lbTheater.Text = "THEATER 3";
                this.plLoadForm.Controls.Add(frmTheater3_View);
                frmTheater3_View.Show();
            }
        }
        public void CalculateTotalMoney()
        {
            if (cbbMovie.SelectedItem != null)
            {
                Film selectedFilm = cbbMovie.SelectedItem as Film;
                int price = selectedFilm.Price;
                int numberOfChair = int.Parse(lbNumberOfChair.Text);
                totalmoney = price * (numberOfChair+1);
                lbMoney.Text = totalmoney.ToString();
            }
        }

        
        public void LoadGhe(int data)
        {
            lbNumberOfChair.Text= data.ToString();
        }
        public void LoadData(List<string> data)
        {
            
            txtDataChair.Text = "";
            txtDataChair.Text = string.Join(",", data);
            CalculateTotalMoney();
        }

        private void cbbMovie_SelectedValueChanged(object sender, EventArgs e)
        {
            chooseFilm(sender);
            openTheater();
            

           


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            FormSellEvent?.Invoke();
            FormSellEvent2?.Invoke();

            frmTheater1 theater1= frmTheater1.GetInStance();
            theater1.ClearSupport();
            Clear();

        }
        public void Clear()
        {
            txtTime.Text = txtPrice.Text = "";
            cbbMovie.SelectedIndex = -1;
            txtDataChair.Text = "";
            lbNumberOfChair.Text = "0";
            lbMoney.Text = "0";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            

            string[] data = { lbTheater.Text, cbbMovie.Text,txtPrice.Text, lbNumberOfChair.Text, lbMoney.Text};
            frmManager manager = frmManager.GetInstance();
            manager.RecieveData(data);
            FormSellEvent?.Invoke();
            FormSellEvent2?.Invoke();
            frmTheater3.GetInStance().OnBtnAcceptClicked();
            Clear();
        }
    }
    public class Film
    {
        public string Movie { get; set; }
        public string Time { get; set; }
        public int Price { get; set; }

    }
}
