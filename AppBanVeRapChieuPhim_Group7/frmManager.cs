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
    public partial class frmManager : Form
    {
        private static frmManager instance;
        public frmManager()
        {
            InitializeComponent();
        }
       public static frmManager GetInstance()
        {
            if(instance == null)
            {
                instance = new frmManager();
            }
            return instance;
        }
        public void RecieveData(string[] data)
        {
            ListViewItem infor = new ListViewItem(data);
            lvManager.Items.Add(infor);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            double tongDT = 0;
            foreach(ListViewItem item in lvManager.Items)
            {
                string b = item.SubItems[4].Text;
                if(double.TryParse(b, out double doanhthu))
                {
                    tongDT = tongDT + doanhthu;
                }
                txtDoanhThu.Text = tongDT.ToString();
            }
        }
    }
}
