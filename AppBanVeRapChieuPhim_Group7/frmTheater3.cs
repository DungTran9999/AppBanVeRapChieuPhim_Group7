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
    public partial class frmTheater3 : Form
    {
        private static frmTheater3 instance;

        public static frmTheater3 GetInStance()
        {
            if (instance == null)
            {
                instance = new frmTheater3();
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
        public frmTheater3()
        {
            InitializeComponent();
        }
        private Dictionary<Button, bool> buttonStates = new Dictionary<Button, bool>();


        public List<string> btnSupport = new List<string>();
        public List<string> btnMain = new List<string>();
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnValue = btn.Text;

            // Add the button to btnSupport if it's not already in there
            if (!btnSupport.Contains(btnValue))
            {
                btnSupport.Add(btnValue);
                btn.BackColor = Color.Green;

                if (truyenData != null)
                {
                    truyenData(btnSupport);
                    this.soluong = btnSupport.Count;
                    truyenghe(soluong);
                }
            }
        }

        public void ClearSupport()
        {
            foreach (string btnValue in btnSupport)
            {
                Button btn = plChairTheater3.Controls.OfType<Button>().FirstOrDefault(b => b.Text == btnValue);
                if (btn != null)
                {
                    // Change the button color back to white if it's not in btnMain
                    if (!btnMain.Contains(btnValue))
                    {
                        btn.BackColor = Color.White;
                    }
                }
            }
            btnSupport.Clear();
            this.soluong = btnSupport.Count;
            truyenghe(soluong);
        }

        public void OnFormSellEventReceived()
        {
            ClearSupport();
            btnMain.Clear();
            // Change the button status back to false
            foreach (Control item in this.plChairTheater3.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    
                    btn.BackColor = Color.White;
                    btn.Click += Btn_Click;
                    buttonStates[btn] = false;
                }
            }
        }

        public void OnBtnAcceptClicked()
        {
            // Check if the conditions are met to save to btnMain
            // If so, save it and change the button colors and text accordingly
            foreach (string btnValue in btnSupport)
            {
                Button btn = plChairTheater3.Controls.OfType<Button>().FirstOrDefault(b => b.Text == btnValue);
                if (btn != null)
                {
                    btnMain.Add(btnValue);
                    btn.BackColor = Color.Green;
                   
                }
            }
        }
    }
}
