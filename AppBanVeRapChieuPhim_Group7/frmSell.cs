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
                new Film(){Movie = "Harry Potter: Dark Witch", Price = 99000},
                new Film(){Movie = "SPIDER-MAN: No Way Home", Price = 110000},
                new Film(){Movie = "THOR: The Dark World", Price = 125000},
                new Film(){Movie = "Fast And Furious", Price = 200000}

            };

            // cbbmovie lấy data từ listItems
            cbbMovie.DataSource = listItem;
            cbbMovie.DisplayMember = "Movie";
        }

        public void chooseFilm(object sender)
        {
            //tạo biến cb từ sender ép kiểu qua combox
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                //chuyển cb sang Film để sử dụng thuộc tính của Film
                Film data = cb.SelectedValue as Film;

                txtPrice.Text = data.Price.ToString();
                
            }

        }
        // mở rạp theo tên phim
        public void openTheater()
        {
            string checkFilm = cbbMovie.Text;
            //
            if (checkFilm == "Harry Potter: Dark Witch")
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
                lblTheater.Text = "1";
                lbTheater.BackColor = Color.Indigo;

                this.plLoadForm.Controls.Add(frmTheater1_View);
                frmTheater1_View.Show();
            }
            else if (checkFilm == "SPIDER-MAN: No Way Home")
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
                lblTheater.Text = "3";
                lbTheater.BackColor = Color.FromArgb(192, 0, 0);

                this.plLoadForm.Controls.Add(frmTheater2_View);
                frmTheater2_View.Show();
            }
            else if (checkFilm == "THOR: The Dark World")
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
                lblTheater.Text = "2";
                lbTheater.BackColor = Color.White;

                this.plLoadForm.Controls.Add(frmTheater3_View);
                frmTheater3_View.Show();
            }
            else if (checkFilm == "Fast And Furious")
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
                lblTheater.Text = "4";
                lbTheater.BackColor = Color.Cyan;

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


        public void LoadGhe(int data)
        {
            lbNumberOfChair.Text = data.ToString();
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
            else if (string.IsNullOrEmpty(cbbTime.Text))
            {
                MessageBox.Show("Vui lòng chọn thêm Time", "Thông Báo");
                return true;
            }
            return false;
        }
        public void Clear()
        {
            cbbTime.Text = txtPrice.Text = "";
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

                frmTicket ticket = frmTicket.GetInStance();
                ticket.RecieveData(lblTheater.Text, cbbMovie.Text, lbMoney.Text, cbbTime.Text, "("+lbNumberOfChair.Text+")", txtDataChair.Text);


                //lấy hàm đã lưu trong theater1AcceptEvent
                theater1AcceptEvent?.Invoke();
                theater2AcceptEvent?.Invoke();
                theater3AcceptEvent?.Invoke();
                theater4AcceptEvent?.Invoke();
                MessageBox.Show("Thanh Toán Thành Công!","THÔNG BÁO");
                Clear();
            }
        }
    }

    //tạo class film để lưu data
    public class Film
    {
        public string Movie { get; set; }
        public string ID { get; set; }
        public int Price { get; set; }

        /*public Film(string id, string movie, int price)
        {
            this.ID= id;
            this.Movie= movie;
            this.Price = price;
        }*/
    }
}