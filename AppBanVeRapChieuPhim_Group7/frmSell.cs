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
        public  Action theater1CancelEvent;
        public  Action theater1AcceptEvent;

        public  Action theater2CancelEvent;
        public  Action theater2AcceptEvent;

        public  Action theater3CancelEvent;
        public  Action theater3AcceptEvent;

        public  Action theater4CancelEvent;
        public  Action theater4AcceptEvent;

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
                new Film(){Movie = "Tấm cám phiêu lưu kí", Price = 125000,  Time = "19h - 20h30"},
                new Film(){Movie = "Conan: Đám Cưới", Price = 200000,  Time = "11h30 - 13h30"}

            };

            
            cbbMovie.DataSource = listItem;
            cbbMovie.DisplayMember = "Movie";
        }

        public void chooseFilm(object sender)
        {
            
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                //chuyển cb sang Film để sử dụng thuộc tính của Film
                Film data = cb.SelectedValue as Film;

                txtPrice.Text = data.Price.ToString();
                txtTime.Text = data.Time.ToString();
            }

        }
        // mở rạp theo tên phim
        public void openTheater()
        {
            string checkFilm = cbbMovie.Text;
            //
            if (checkFilm == "Ba Con Heo")
            {
                this.plLoadForm.Controls.Clear();
                frmTheater1 frmTheater1_View = frmTheater1.GetInStance();
                frmTheater1_View.Dock = DockStyle.Fill;
                frmTheater1_View.TopLevel = false;
                frmTheater1_View.TopMost = true;
                frmTheater1_View.FormBorderStyle = FormBorderStyle.None;

                // thêm hàm HandleCancelEvent từ frmTheater1 vào theater1CancelEvent
                theater1CancelEvent += frmTheater1_View.HandleCancelEvent;
                // thêm hàm HandleAcceptEvent từ frmTheater1 vào theater1AcceptEvent
                theater1AcceptEvent += frmTheater1_View.HandleAcceptEvent;


                frmTheater1_View.truyenData += LoadData;

                frmTheater1_View.truyenghe += LoadGhe;


                lbTheater.Text = "THEATER 1";
                lbTheater.BackColor = Color.FromArgb(192, 255, 192);

                this.plLoadForm.Controls.Add(frmTheater1_View);
                frmTheater1_View.Show();
            }
            else if (checkFilm == "Tấm cám phiêu lưu kí")
            {
                this.plLoadForm.Controls.Clear();
                frmTheater2 frmTheater2_View = frmTheater2.GetInStance();
                frmTheater2_View.Dock = DockStyle.Fill;
                frmTheater2_View.TopLevel = false;
                frmTheater2_View.TopMost = true;
                frmTheater2_View.FormBorderStyle = FormBorderStyle.None;

                // thêm hàm HandleCancelEvent từ frmTheater2 vào theater1CancelEvent
                theater2CancelEvent += frmTheater2_View.HandleCancelEvent;
                // thêm hàm HandleAcceptEvent từ frmTheater2 vào theater1AcceptEvent
                theater2AcceptEvent += frmTheater2_View.HandleAcceptEvent;

                frmTheater2_View.truyenData2 += LoadData;
                frmTheater2_View.truyenghe2 += LoadGhe;

                lbTheater.Text = "THEATER 3";
                lbTheater.BackColor = Color.FromArgb(192, 255, 255);

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

                // thêm hàm HandleCancelEvent từ frmTheater3 vào theater1CancelEvent
                theater3CancelEvent += frmTheater3_View.HandleCancelEvent;
                // thêm hàm HandleAcceptEvent từ frmTheater3 vào theater1AcceptEvent
                theater3AcceptEvent += frmTheater3_View.HandleAcceptEvent;

                frmTheater3_View.truyenData3 += LoadData;
                frmTheater3_View.truyenghe3 += LoadGhe;

                lbTheater.Text = "THEATER 2";
                lbTheater.BackColor = Color.FromArgb(255, 192, 255);

                this.plLoadForm.Controls.Add(frmTheater3_View);
                frmTheater3_View.Show();
            }
            else if (checkFilm == "Conan: Đám Cưới")
            {
                this.plLoadForm.Controls.Clear();
                frmTheater4 frmTheater4_View = frmTheater4.GetInStance();
                frmTheater4_View.Dock = DockStyle.Fill;
                frmTheater4_View.TopLevel = false;
                frmTheater4_View.TopMost = true;
                frmTheater4_View.FormBorderStyle = FormBorderStyle.None;

                // thêm hàm HandleCancelEvent từ frmTheater4 vào theater1CancelEvent
                theater4CancelEvent += frmTheater4_View.HandleCancelEvent;
                // thêm hàm HandleAcceptEvent từ frmTheater4 vào theater1AcceptEvent
                theater4AcceptEvent += frmTheater4_View.HandleAcceptEvent;

                frmTheater4_View.truyenData4 += LoadData;
                frmTheater4_View.truyenghe4 += LoadGhe;

                lbTheater.Text = "THEATER 4";
                lbTheater.BackColor = Color.FromArgb(255, 128, 0);

                this.plLoadForm.Controls.Add(frmTheater4_View);
                frmTheater4_View.Show();
            }
        }
        public void CalculateTotalMoney()
        {
            if (cbbMovie.SelectedItem != null)
            {
                Film selectedFilm = cbbMovie.SelectedItem as Film;
                int price = selectedFilm.Price;
                int numberOfChair = int.Parse(lbNumberOfChair.Text);
                totalmoney = price * (numberOfChair + 1);
                lbMoney.Text = totalmoney.ToString();
            }
        }


        public void LoadGhe(int ghe)
        {
            lbNumberOfChair.Text = ghe.ToString();
        }
        public void LoadData(List<string> data)
        {

            txtDataChair.Text = "";
            txtDataChair.Text = string.Join(",  ", data);
            CalculateTotalMoney();
        }

        private void cbbMovie_SelectedValueChanged(object sender, EventArgs e)
        {
            chooseFilm(sender);
            openTheater();

        }

        private bool kiemTracbbMovieTruocKhiAnfrmTheater()
        {
            if (string.IsNullOrEmpty(cbbMovie.Text))
            {
                MessageBox.Show("Vui lòng chọn thêm phim", "Thông Báo");
                return true;
            }
            return false;
        }
        public void Clear()
        {
            txtTime.Text = txtPrice.Text = "";
            cbbMovie.SelectedIndex = -1;
            txtDataChair.Text = "";
            lbNumberOfChair.Text = "0";
            lbMoney.Text = "0";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (kiemTracbbMovieTruocKhiAnfrmTheater())
            {
                return;
            }
            else
            {
                //lấy hàm đã lưu trong theater1CancelEvent
                theater1CancelEvent?.Invoke();
                theater2CancelEvent?.Invoke();
                theater3CancelEvent?.Invoke();
                theater4CancelEvent?.Invoke();

                Clear();
            }
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (kiemTracbbMovieTruocKhiAnfrmTheater())
            {
                return;
            }
            else
            {
                // tạo mảng frmSell để truyền data vô frmManager
                string[] data = { lbTheater.Text, cbbMovie.Text, txtPrice.Text, lbNumberOfChair.Text, lbMoney.Text };
                frmManager manager = frmManager.GetInstance();
                manager.RecieveData(data);


                //lấy hàm đã lưu trong theater1AcceptEvent
                theater1AcceptEvent?.Invoke();
                theater2AcceptEvent?.Invoke();
                theater3AcceptEvent?.Invoke();
                theater4AcceptEvent?.Invoke();
                MessageBox.Show("Cập nhật Thành Công!","THÔNG BÁO");
                Clear();
            }
        }
    }

    //tạo class film để lưu data
    public class Film
    {
        public string Movie { get; set; }
        public string Time { get; set; }
        public int Price { get; set; }
        public string ID { get; set; }

    }
}