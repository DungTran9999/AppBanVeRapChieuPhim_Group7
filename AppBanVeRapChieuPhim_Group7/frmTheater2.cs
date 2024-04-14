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
        private static frmTheater2 instance;

        public static frmTheater2 GetInStance()
        {
            if (instance == null)
            {
                instance = new frmTheater2();
            }
            return instance;
        }

        public delegate void delPassData(List<string> value);
        public delPassData truyenData2;

        public int soluong { get; set; }

        public delegate void TruyenGhe2(int ghe);
        public TruyenGhe2 truyenghe2;

        public frmTheater2()
        {
            InitializeComponent();
            xuliBtn();

        }

        private Dictionary<Button, bool> buttonStates = new Dictionary<Button, bool>();


        public List<string> listSupport = new List<string>();
        public List<string> listMain = new List<string>();
        public void xuliBtn()
        {
            foreach (Control item in this.plChairTheater2.Controls)
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
               
                return;
            }

            if (listSupport.Count >= 15)
            {
                MessageBox.Show("Giới hạn chọn ghế là 15", "Thông Báo");
                return;
            }


            buttonStates[btn] = !buttonStates[btn];

            if (buttonStates[btn])
            {
                btn.BackColor = Color.Green;
                listSupport.Add(btnText);

                if (listSupport.Contains(btnText))
                {


                    if (truyenData2 != null)
                    {

                        truyenData2(listSupport);
                        this.soluong = listSupport.Count;
                        truyenghe2(soluong);
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
          
            Dictionary<string, Color> buttonColors = new Dictionary<string, Color>();
            foreach (string btnText in listSupport)
            {
                Button btn = plChairTheater2.Controls.OfType<Button>().FirstOrDefault(b => b.Text == btnText);
                if (btn != null)
                {
                    buttonColors.Add(btnText, btn.BackColor);
                }
            }

            listMain.AddRange(listSupport);
            ClearListSupport(); 

         
            foreach (var kvp in buttonColors)
            {
                Button btn = plChairTheater2.Controls.OfType<Button>().FirstOrDefault(b => b.Text == kvp.Key);
                if (btn != null)
                {
                    btn.BackColor = kvp.Value;
                }
            }
        }
        public void HandleCancelEvent()
        {
            ClearListSupport(); 
        }
        private void ClearListSupport()
        {
            foreach (string btnText in listSupport)
            {
                Button btn = plChairTheater2.Controls.OfType<Button>().FirstOrDefault(b => b.Text == btnText);
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
