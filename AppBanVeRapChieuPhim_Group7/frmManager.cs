using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppBanVeRapChieuPhim_Group7
{
    public partial class frmManager : Form
    {
        private static frmManager instance;
        public frmManager()
        {
            InitializeComponent();
            lblDoanhThu.BackColor = Color.Transparent;
            lblRank.BackColor = Color.Transparent;
            
            
        }
        public static frmManager GetInstance()
        {
            if (instance == null)
            {
                instance = new frmManager();
            }
            return instance;
        }


        //
        public void RecieveData(string[] data)
        {
            ListViewItem infor = new ListViewItem(data);
            lvManager.Items.Add(infor);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThu();
            CalculateAndDisplayRankings();
        }
        public void DoanhThu()
        {
            double tongDT = 0;
            foreach (ListViewItem item in lvManager.Items)
            {
                string b = item.SubItems[4].Text;
                if (double.TryParse(b, out double doanhthu))
                {
                    tongDT = tongDT + doanhthu;
                }
                txtDoanhThu.Text = tongDT.ToString();
            }
        }
        private void CalculateAndDisplayRankings()
        {
            Dictionary<string, int> movieSeatCounts = new Dictionary<string, int>();

            // Lặp qua mỗi dòng trong ListView để tính tổng số ghế đã chọn cho mỗi bộ phim
            foreach (ListViewItem item in lvManager.Items)
            {
                string movieName = item.SubItems[1].Text; // Lấy tên phim từ cột 0
                int seatCount = int.Parse(item.SubItems[3].Text); // Lấy số ghế đã chọn từ cột 2

                // Cộng dồn số lượng ghế đã chọn cho mỗi bộ phim
                if (movieSeatCounts.ContainsKey(movieName))
                {
                    movieSeatCounts[movieName] += seatCount;
                }
                else
                {
                    movieSeatCounts[movieName] = seatCount;
                }
            }

            // Chuyển dictionary sang một danh sách để dễ sắp xếp
            List<KeyValuePair<string, int>> sortedMovies = new List<KeyValuePair<string, int>>(movieSeatCounts);

            // Sắp xếp các bộ phim theo số ghế đã chọn giảm dần
            sortedMovies.Sort((x, y) => y.Value.CompareTo(x.Value));

            // Xóa các mục từ ListBox
            lbRank.Items.Clear();

            // Thêm các bộ phim đã sắp xếp vào ListBox với đánh xếp hạng và màu sắc tương ứng
            for (int i = 0; i < Math.Min(sortedMovies.Count, 3); i++)
            {
                string movieName = sortedMovies[i].Key;
                int seatCount = sortedMovies[i].Value;

                // Tạo chuỗi đánh xếp hạng
                string ranking = $"Top {i + 1}: {movieName} ({seatCount})";

                // Thêm mục vào ListBox
                lbRank.Items.Add(ranking);

                // Đặt màu sắc cho mục vừa thêm

            }
        }


    }
}