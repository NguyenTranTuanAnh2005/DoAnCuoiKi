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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // Thiết lập để Form luôn nằm giữa màn hình khi mở
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // 1. Chức năng Thêm: Lấy dữ liệu từ TextBox và thêm vào DataGridView
        private void btnAddIteam_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã nhập Mã và Tên chưa
                if (string.IsNullOrWhiteSpace(txtIdIteam.Text) || string.IsNullOrWhiteSpace(txtNameIteam.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên món hàng!", "Thông báo");
                    return;
                }

                // Thêm một dòng mới vào dataGridView1 dựa trên các cột đã định nghĩa
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["iditeam"].Value = txtIdIteam.Text;
                dataGridView1.Rows[n].Cells["nameiteam"].Value = txtNameIteam.Text;
                dataGridView1.Rows[n].Cells["gia"].Value = txtGia.Text;
                dataGridView1.Rows[n].Cells["soluong"].Value = txtSoLuong.Text;

                // Sau khi thêm xong thì xóa trắng các ô nhập
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }

        // 2. Chức năng Sửa: Cập nhật dòng đang được chọn trong bảng
        private void btnUpIteam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                row.Cells["iditeam"].Value = txtIdIteam.Text;
                row.Cells["nameiteam"].Value = txtNameIteam.Text;
                row.Cells["gia"].Value = txtGia.Text;
                row.Cells["soluong"].Value = txtSoLuong.Text;
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong danh sách để sửa!");
            }
        }

        // 3. Chức năng Xóa: Loại bỏ dòng đang chọn khỏi DataGridView
        private void btnDeleteIteam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                // Hỏi xác nhận trước khi xóa cho chắc chắn
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }
        }

        // 4. Thoát thông qua MenuStrip (thoátToolStripMenuItem)
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form4
        }

        // Hàm bổ trợ để làm trống các TextBox
        private void ClearFields()
        {
            txtIdIteam.Clear();
            txtNameIteam.Clear();
            txtGia.Text = "0";
            txtSoLuong.Text = "0";
            txtIdIteam.Focus(); // Đặt con trỏ chuột vào ô Mã để nhập tiếp
        }

        // Sự kiện hỗ trợ: Khi nhấn vào một dòng trong bảng, hiển thị ngược lại lên TextBox để Sửa/Xóa
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtIdIteam.Text = row.Cells["iditeam"].Value?.ToString();
                txtNameIteam.Text = row.Cells["nameiteam"].Value?.ToString();
                txtGia.Text = row.Cells["gia"].Value?.ToString();
                txtSoLuong.Text = row.Cells["soluong"].Value?.ToString();
            }
        }
    }
}