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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Đảm bảo Form hiển thị ở giữa màn hình khi mở
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // 1. Xử lý nút Nhập hàng
        private void btnAddItean_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hệ thống đang mở giao diện Nhập hàng...", "Thông báo");
            // Tại đây bạn có thể gọi Form nhập hàng nếu có:
            // FormNhapHang f = new FormNhapHang();
            // f.ShowDialog();
        }

        // 2. Xử lý nút Quản lý kho
        private void btnQLK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hệ thống đang truy cập dữ liệu Kho hàng...", "Thông báo");
        }

        // 3. Xử lý nút Kiểm kê hàng hóa
        private void btnKKSL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bắt đầu quy trình kiểm kê số lượng sản phẩm.", "Thông báo");
        }

        // 4. Xử lý nút Thoát
        private void btnOut_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có muốn quay lại Trang chủ không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng Form3
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}