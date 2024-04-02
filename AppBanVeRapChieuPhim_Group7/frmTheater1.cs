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

        private static frmTheater1 instance;
        
        public static frmTheater1 GetInStance()
        {
            if( instance == null)
            {
                instance = new frmTheater1();
            }
            return instance;
        }

        public delegate void delPassData(List<string> value);
        public delPassData truyenData;

        //Nhan su kien tu form sell
        public event Action FormSellEventReceived;
        public int soluong { get; set; }

        public delegate void TruyenGhe(int soluong);
        public TruyenGhe truyenghe;

        public frmTheater1()
        {
            InitializeComponent();
            xuliBtn();
          
        }

        private Dictionary<Button, bool> buttonStates = new Dictionary<Button, bool>();

        
        public List<string> btnSupport = new List<string>();
        public List<string> btnMain = new List<string>();
        public void xuliBtn()
        {
            foreach (Control item in this.plChairTheater1.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Click += Btn_Click;
                    buttonStates.Add(btn, false);

                }
            }
        }
        

        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            string btnValue = btn.Text;

            if (!buttonStates[btn])
            {
                btn.BackColor = Color.Green;
                buttonStates[btn] = true;

                
                

                btnMain.Add(btnValue);
            }

            // Kiểm tra xem giá trị của button đã tồn tại trong danh sách chưa


            if (!btnSupport.Contains(btnValue))
            {
                btnSupport.Add(btnValue);

                if (truyenData != null)
                {
                    truyenData(btnSupport);
                    this.soluong=btnSupport.Count;
                    truyenghe(soluong);
                }
            }


        }
        public void ClearSupport()
        {
            foreach (string btnValue in btnSupport)
            {
                Button btn = plChairTheater1.Controls.OfType<Button>().FirstOrDefault(b => b.Text == btnValue);
                if (btn != null)
                {
                    btn.BackColor = Color.White;
                    buttonStates[btn] = false;
                }
            }
            btnSupport.Clear();
        }
        public void Clearlist()
        {
            btnSupport.Clear();
        }
        public void OnFormSellEventReceived()
        {
            // Xóa dữ liệu khi nhận sự kiện từ form Sell
            Clearlist();
            
        }

       





    }

}
