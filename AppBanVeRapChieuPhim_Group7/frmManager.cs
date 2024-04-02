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
        

        
    }
}
