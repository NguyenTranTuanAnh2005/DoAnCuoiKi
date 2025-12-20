using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            // Thiết lập Form hiển thị giữa màn hình khi mở
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // 1. Chức năng thoát chương trình qua Menu
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form5 để quay lại
        }

        // 2. Chức năng Liệt kê theo giá (Giả lập đổ dữ liệu vào bảng)
        private void TSMIform5_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ trước khi nạp mới
            dataGridView1.Rows.Clear();

            // Lấy ngày đang chọn từ DateTimePicker
            string ngayChon = dtpChonNgay.Value.ToShortDateString();

            // Thêm dữ liệu mẫu (Sau này bạn có thể kết nối Cơ sở dữ liệu tại đây)
            dataGridView1.Rows.Add(ngayChon, "SP001", "Bánh ngọt", "10");
            dataGridView1.Rows.Add(ngayChon, "SP002", "Nước suối", "25");

            MessageBox.Show("Đã liệt kê danh sách bán hàng theo giá.", "Thông báo");
        }

        // 3. Chức năng Liệt kê theo số lượng bán ra
        private void liệtKêTheoSốLượngBánRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ở đây bạn có thể viết code sắp xếp DataGridView theo cột Số lượng
            dataGridView1.Sort(dataGridView1.Columns["SoLuong2"], ListSortDirection.Descending);
            MessageBox.Show("Đã sắp xếp theo số lượng bán ra giảm dần.", "Thông báo");
        }

        // 4. Sự kiện xảy ra khi người dùng thay đổi ngày trên DateTimePicker
        private void dtpChonNgay_ValueChanged(object sender, EventArgs e)
        {
            // Khi chọn ngày mới, bạn có thể tự động nạp lại dữ liệu
            // LoadDataByDate(dtpChonNgay.Value); 
        }
    }
}
