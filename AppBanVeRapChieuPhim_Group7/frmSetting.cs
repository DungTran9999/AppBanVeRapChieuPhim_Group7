using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppBanVeRapChieuPhim_Group7
{
    public partial class frmSetting : Form
    {
        private static frmSetting instance;

        public static frmSetting GetInStance()
        {
            if (instance == null)
            {
                instance = new frmSetting();
            }
            return instance;
        }
        public frmSetting()
        {
            InitializeComponent();
        }
        public void loadData()
        {
           
        }
      
    }
    
}
