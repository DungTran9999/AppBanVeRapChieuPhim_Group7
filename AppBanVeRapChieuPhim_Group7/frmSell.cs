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
                new Film(){Movie = "Báo Hồng", Price = 89000,  Time = "13h - 14h30"},
                new Film(){Movie = "Điệp Viên 069", Price = 95000, Time = "16h - 17h30"},
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

        private void btnTheater1_Click(object sender, EventArgs e)
        {
           
            this.plLoadForm.Controls.Clear();
            frmTheater1 frmTheater1_View = new frmTheater1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTheater1_View.FormBorderStyle = FormBorderStyle.None;
           
            FormSellEvent += frmTheater1_View.OnFormSellEventReceived;

            frmTheater1_View.truyenData += LoadData;
            frmTheater1_View.truyenghe += LoadGhe;
            int a = frmTheater1_View.soluong;
            

            this.plLoadForm.Controls.Add(frmTheater1_View);
            frmTheater1_View.Show();
        }


        private void btnTheater2_Click(object sender, EventArgs e)
        {
            this.plLoadForm.Controls.Clear();
            frmTheater2 frmTheater2_View = new frmTheater2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmTheater2_View.FormBorderStyle = FormBorderStyle.None;

            frmTheater2_View.truyenData2 += LoadData;
            frmTheater2_View.truyenghe2 += LoadGhe;
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
            CalculateTotalMoney();
        }

        private void cbbMovie_SelectedValueChanged(object sender, EventArgs e)
        {
            chooseFilm(sender);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            FormSellEvent?.Invoke();
            FormSellEvent2?.Invoke();

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
            string[] data = {cbbMovie.Text,txtPrice.Text, lbNumberOfChair.Text, lbMoney.Text};
            frmManager manager = frmManager.GetInstance();
            manager.RecieveData(data);
            FormSellEvent?.Invoke();
            FormSellEvent2?.Invoke();
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
