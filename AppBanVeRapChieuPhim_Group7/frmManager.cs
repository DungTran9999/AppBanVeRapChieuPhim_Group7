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
        public frmManager()
        {
            InitializeComponent();
         
        }
        private static frmManager instance;
        public static frmManager Instance 
        {
            get
            {
                 if(instance == null)
                 
                    instance = new frmManager();
                    return frmManager.instance;
                 
            }
            set
            {
                frmManager.instance = value;
            }
        }
        
        public void AddDataToListView(string[] data)
        {
            ListViewItem items = new ListViewItem(data);
            lvManager.Items.AddRange(new ListViewItem[] { items });
        }
    }
}
