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
    public partial class frmTheater1 : Form
    {
        public delegate void delPassData(List<string> value);
        public delPassData truyenData;
        public event Action FormSellEventReceived;
        public int soluong { get; set; }
        public delegate void TruyenGhe(int soluong);
        public TruyenGhe truyenghe;

        public frmTheater1()
        {
            InitializeComponent();
            xuliBtn();
        }

        public List<string> btnNhan = new List<string>();
        public void xuliBtn()
        {
            foreach (Control item in this.plChairTheater1.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Click += Btn_Click;

                }
            }
        }

        

        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            string btnValue = btn.Text;

            // Kiểm tra xem giá trị của button đã tồn tại trong danh sách chưa


            if (!btnNhan.Contains(btnValue))
            {
                btnNhan.Add(btnValue);

                if (truyenData != null)
                {
                    truyenData(btnNhan);
                    this.soluong=btnNhan.Count;
                    truyenghe(soluong);
                }
            }


        }
        public void Clearlist()
        {
            btnNhan.Clear();
        }
        public void OnFormSellEventReceived()
        {
            // Xóa dữ liệu khi nhận sự kiện từ form Sell
            Clearlist();
        }
    }

}
