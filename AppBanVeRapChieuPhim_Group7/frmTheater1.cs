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
        public event Action AcceptEvent;
        public event Action CancelEvent;
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
       
        public int soluong { get; set; }

        public delegate void TruyenGhe(int soluong);
        public TruyenGhe truyenghe;

        public frmTheater1()
        {
            InitializeComponent();
            xuliBtn();
          
        }

        private Dictionary<Button, bool> buttonStates = new Dictionary<Button, bool>();

        
        public List<string> listSupport = new List<string>();
        public List<string> listMain = new List<string>();
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
            string btnText = btn.Text;

            // Đảo ngược trạng thái của ghế
            buttonStates[btn] = !buttonStates[btn];

            if (buttonStates[btn])
            {
                btn.BackColor = Color.Green;
                listSupport.Add(btnText);

                if (listSupport.Contains(btnText))
                {
                    

                    if (truyenData != null)
                    {
                       
                        truyenData(listSupport);
                        this.soluong = listSupport.Count;
                        truyenghe(soluong);
                    }
                }
            }
            else
            {
                btn.BackColor = DefaultBackColor;
                listSupport.Remove(btnText);
            }
        }
        public void HandleAcceptEvent()
        {
            listMain.AddRange(listSupport); // Thêm danh sách ghế được chọn vào listMain
            ClearListSupport(); // Xóa danh sách ghế đang được chọn
        }
        public void HandleCancelEvent()
        {
            ClearListSupport(); // Xóa danh sách ghế đang được chọn
        }
        private void ClearListSupport()
        {
            foreach (string btnText in listSupport)
            {
                Button btn = plChairTheater1.Controls.OfType<Button>().FirstOrDefault(b => b.Text == btnText);
                if (btn != null)
                {
                    btn.BackColor = DefaultBackColor;
                    buttonStates[btn] = false;
                }
            }
            listSupport.Clear();
        }


    }

}
