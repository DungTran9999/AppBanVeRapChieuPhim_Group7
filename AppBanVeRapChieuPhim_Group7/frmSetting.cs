using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
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
            
            
            PopulateListView();
            
        }
        
        
        
        private void PopulateListView()
        {
            // Xóa dữ liệu cũ trong ListView (nếu có)
            lvControl.Items.Clear();

            // Duyệt qua mỗi đối tượng Film trong listItem2
            foreach (Film film in listItem2)
            {
                // Tạo một ListViewItem mới với các thông tin của đối tượng Film
                ListViewItem listViewItem = new ListViewItem(film.ID);
                listViewItem.SubItems.Add(film.Movie);
                listViewItem.SubItems.Add(film.Price.ToString());
                listViewItem.SubItems.Add(film.Time);

                // Thêm ListViewItem vào ListView
                lvControl.Items.Add(listViewItem);
            }
        }

        private void lvControl_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var selectedItem = e.Item;
                txtID.Text = selectedItem.SubItems[0].Text;
                txtMovie.Text = selectedItem.SubItems[1].Text;
                txtPrice.Text = selectedItem.SubItems[2].Text;
                txtTime.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ID1=txtID.Text; 
            Movie1 = txtMovie.Text; 
            Price1 = Convert.ToInt32(txtPrice.Text);
            Time1 = txtTime.Text;
        }
    }
}
