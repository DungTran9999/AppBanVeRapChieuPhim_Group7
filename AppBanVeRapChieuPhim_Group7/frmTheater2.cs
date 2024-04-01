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
    public partial class frmTheater2 : Form
    {
        public delegate void delPassData(List<string> value);
        public delPassData truyenData2;

        //Nhan su kien tu form sell
        public event Action FormSellEventReceived2;
        public int soluong2 { get; set; }

        public delegate void TruyenGhe(int soluong);
        public TruyenGhe truyenghe2;

        public frmTheater2()
        {
            InitializeComponent();
            xuliBtn2();
        }

        public List<string> btnNhan2 = new List<string>();
        public void xuliBtn2()
        {
            foreach (Control item in this.plTheater2.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Click += Btn_Click2;

                }
            }
        }


        private void Btn_Click2(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            string btnValue2 = btn.Text;

            // Kiểm tra xem giá trị của button đã tồn tại trong danh sách chưa


            if (!btnNhan2.Contains(btnValue2))
            {
                btnNhan2.Add(btnValue2);

                if (truyenData2 != null)
                {
                    truyenData2(btnNhan2);
                    this.soluong2 = btnNhan2.Count;
                    truyenghe2(soluong2);
                }
            }


        }
        public void Clearlist()
        {
            btnNhan2.Clear();
        }
        public void OnFormSellEventReceived2()
        {
            // Xóa dữ liệu khi nhận sự kiện từ form Sell
            Clearlist();
        }
    }
}
