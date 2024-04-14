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
    public partial class frmCustomer : Form
    {
        private static frmCustomer instance;
        public static frmCustomer GetInStance()
        {
            if (instance == null)
            {
                instance = new frmCustomer();
            }
            return instance;
        }
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(0, 10000);
            txtID.Text = a.ToString("D4");
        }
        public void XoaDuLieuForm()
        {
            txtID.Text = txtAge.Text = txtName.Text = cbbAddress.Text = cbbGender.Text =txtDisCount.Text= "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkinput())
            {
                return;
            }
            else
            {

                ListViewItem itemSinhVien = new ListViewItem(new string[]
                       {txtID.Text,txtName.Text,txtAge.Text,cbbGender.Text,cbbAddress.Text });
                lvCTMList.Items.AddRange(new ListViewItem[] { itemSinhVien });
                XoaDuLieuForm();
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
                foreach (ListViewItem it in lvCTMList.Items)
                {
                    if (it.SubItems[0].Text == maSSV)
                    {
                        it.Remove();
                        MessageBox.Show("Xóa thành công");
                        XoaDuLieuForm();
                        txtID.Enabled = true;
                        btnRandom.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void lvCTMList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txtID.Text = item.SubItems[0].Text;
            txtName.Text = item.SubItems[1].Text;
            txtAge.Text = item.SubItems[2].Text;

            cbbGender.Text = item.SubItems[3].Text;
            cbbAddress.Text = item.SubItems[4].Text;
            txtID.Enabled = false;
            btnRandom.Enabled = false;
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            int TongDong = lvCTMList.Items.Count;
            for (int i = 0; i < TongDong; i++)
            {
                if (lvCTMList.Items[i].Text == txtID.Text)
                {
                    lvCTMList.Items[i].SubItems[1].Text = txtName.Text;
                    lvCTMList.Items[i].SubItems[2].Text = txtAge.Text;
                    lvCTMList.Items[i].SubItems[3].Text = cbbGender.Text;
                    lvCTMList.Items[i].SubItems[4].Text = cbbAddress.Text;
                    return;
                }
            }

            MessageBox.Show("Cập nhật thành công”,”Thông báo");
            XoaDuLieuForm();
            txtID.Enabled = true;
            btnRandom.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            XoaDuLieuForm();
            txtID.Enabled = true;
            btnRandom.Enabled = true;
        }
        public bool checkinput()
        {
            string checkage=txtAge.Text;
            if (int.TryParse(checkage, out int b) == false)
            {
                MessageBox.Show("Tuổi là 1 con số");
                return true;
            }
            else if (Convert.ToInt32(txtAge.Text) < 12 || Convert.ToInt32(txtAge.Text) > 100)
            {
                MessageBox.Show("Tuổi lớn 3 và nhỏ hơn 100");
                return true;
            }
            else if (string.IsNullOrEmpty(txtAge.Text) ||
                string.IsNullOrEmpty(txtDisCount.Text) ||
                string.IsNullOrEmpty(txtID.Text) ||
                    string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(cbbAddress.Text) ||
                string.IsNullOrEmpty(cbbGender.Text)
                )
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return true;
            }
            foreach (ListViewItem item in lvCTMList.Items)
            {
                    if (item.SubItems[0].Text == txtID.Text)
                    {
                        MessageBox.Show("ID không được trùng", "Lỗi");
                        return true;
                    } 
                    else if (item.SubItems[1].Text == txtName.Text)
                    {
                    MessageBox.Show("Name không được trùng", "Lỗi");
                    return true;
                    }
            } 

            return false;
        }
    } 
}
