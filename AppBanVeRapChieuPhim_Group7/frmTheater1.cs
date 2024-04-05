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
       
        public int soluong { get; set; }

        public delegate void TruyenGhe(int ghe);
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

            if (listMain.Contains(btnText))
            {
                // Nếu nút đã được chọn nằm trong listMain, không thực hiện gì cả
                return;
            }

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
            // Lưu trạng thái màu của các ghế trong listSupport
            Dictionary<string, Color> buttonColors = new Dictionary<string, Color>();
            foreach (string btnText in listSupport)
            {
                Button btn = plChairTheater1.Controls.OfType<Button>().FirstOrDefault(b => b.Text == btnText);
                if (btn != null)
                {
                    buttonColors.Add(btnText, btn.BackColor);
                }
            }

            listMain.AddRange(listSupport); // Thêm danh sách ghế được chọn vào listMain
            ClearListSupport(); // Xóa danh sách ghế đang được chọn

            // Tái áp dụng màu cho các ghế tương ứng trong listSupport
            foreach (var kvp in buttonColors)
            {
                Button btn = plChairTheater1.Controls.OfType<Button>().FirstOrDefault(b => b.Text == kvp.Key);
                if (btn != null)
                {
                    btn.BackColor = kvp.Value;
                }
            }
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
