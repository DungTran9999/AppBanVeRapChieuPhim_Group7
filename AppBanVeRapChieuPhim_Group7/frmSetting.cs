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
        List<Film> listfilm = new List<Film>();

        public void test1()
        {
            string a= txtID.Text;
            string b= txtMovie.Text;
            int c= Convert.ToInt32(txtPrice.Text);

            
            Film film = new Film(a,b,c);
            listfilm.Add(film);
            
            foreach(Film item in listfilm)
            {
                ListViewItem lv = new ListViewItem(film.ID);
                lv.SubItems.Add(film.Movie);
                lv.SubItems.Add(film.Price.ToString());
                lvMVList.Items.Add(lv);
            }
        }
        public List <string> test2()
        {
            List<string> Value = new List<string>();
            foreach (ListViewItem item in lvMVList.Items)
            {
                Value.Add(item.SubItems[1].Text);
            }
            return Value;
        }

            public bool checkinput()
        {
            if (txtID.Text.Length != 3 )
            {
                MessageBox.Show("Kiểm tra xem ID phải đúng 3 số");
                txtID.Focus();
                return true;
            }
            else if ( string.IsNullOrWhiteSpace(txtID.Text) || 
                      string.IsNullOrWhiteSpace(txtMovie.Text) ||
                      string.IsNullOrWhiteSpace(txtPrice.Text) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Lỗi");
                return true;
            }
            return false;
        }
        private bool kiemtratrung()
        {
            foreach (ListViewItem item in lvMVList.Items)
            {
                if (item.SubItems[0].Text == txtID.Text)
                {
                    MessageBox.Show("ID đã tồn tại", "Lỗi");
                    return true;
                }

                if (item.SubItems[1].Text == txtMovie.Text)
                {
                    MessageBox.Show("Movie đã tồn tại", "Lỗi");
                    return true;
                }
            }

            return false;
        }
        public void XoaDuLieuForm()
        {
            txtID.Text= txtMovie.Text=txtPrice.Text="";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkinput())
            {
                return;
            }
            else if (kiemtratrung())
            {
                return;
            }

            else
            {
                ListViewItem itemSinhVien = new ListViewItem(new string[]
                  {txtID.Text,txtMovie.Text,txtPrice.Text});
                lvMVList.Items.AddRange(new ListViewItem[] { itemSinhVien });

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maSSV = txtID.Text.Trim();
            if (maSSV == "")
            {
                MessageBox.Show("Bạn chưa chọn thông tin sinh viên cần xóa");
            }
            else
            {
                foreach (ListViewItem it in lvMVList.Items)
                {
                    if (it.SubItems[0].Text == maSSV)
                    {
                        it.Remove();
                        MessageBox.Show("Xóa thành công");
                        XoaDuLieuForm();
                        txtID.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            int TongDong = lvMVList.Items.Count;
            for (int i = 0; i < TongDong; i++)
            {
                if (lvMVList.Items[i].Text == txtID.Text)
                {
                    lvMVList.Items[i].SubItems[1].Text = txtMovie.Text;
                    lvMVList.Items[i].SubItems[2].Text = txtPrice.Text;
                    return;
                }
            }
            txtID.Enabled = true;
            MessageBox.Show("Cập nhật thành công”,”Thông báo");
            XoaDuLieuForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            XoaDuLieuForm();
        }

        private void lvMVList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txtID.Text = item.SubItems[0].Text;
            txtMovie.Text = item.SubItems[1].Text;
            txtPrice.Text = item.SubItems[2].Text;
            txtID.Enabled = false;
           
        }
    }
}
