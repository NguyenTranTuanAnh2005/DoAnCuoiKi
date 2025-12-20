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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            // Thiết lập để Form luôn hiển thị ở chính giữa màn hình khi mở
            this.StartPosition = FormStartPosition.CenterScreen;

            // Đăng ký sự kiện Load và Click cho các điều khiển nếu bạn chưa làm trong Designer
            this.Load += new System.EventHandler(this.Form6_Load);
            this.btnoutt.Click += new System.EventHandler(this.btnoutt_Click);
        }

        /// <summary>
        /// Sự kiện xảy ra khi Form được nạp lên. 
        /// Dùng để đổ dữ liệu vào DataGridView dựa trên các cột đã tạo trong Designer.
        /// </summary>
        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                // Xóa các dòng cũ (nếu có) trước khi nạp dữ liệu mới
                dataGridView1.Rows.Clear();

                // Thêm dữ liệu mẫu vào bảng dựa trên các tên cột trong designer:
                // Cột 0: IdIteam3 (Mã), Cột 1: NameIteam3 (Tên), Cột 2: SoLuong3 (Tồn), Cột 3: SoLuonDaBan (Đã bán)
                dataGridView1.Rows.Add("MH001", "Bánh ngọt ABC", "45", "120");
                dataGridView1.Rows.Add("MH002", "Nước giải khát", "12", "350");
                dataGridView1.Rows.Add("MH003", "Kẹo mút trái cây", "8", "210");
                dataGridView1.Rows.Add("MH004", "Sữa tươi không đường", "60", "85");

                // Gọi hàm kiểm tra cảnh báo hàng sắp hết
                KiemTraHangSapHet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu: " + ex.Message, "Lỗi hệ thống");
            }
        }

        /// <summary>
        /// Xử lý sự kiện nhấn nút Thoát (btnoutt)
        /// </summary>
        private void btnoutt_Click(object sender, EventArgs e)
        {
            // Đóng Form6 để quay trở lại Form quản lý trước đó
            this.Close();
        }

        /// <summary>
        /// Hàm bổ sung: Kiểm tra số lượng tồn kho và tô màu cảnh báo
        /// </summary>
        private void KiemTraHangSapHet()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra giá trị ở cột SoLuong3 (cột thứ 3 trong bảng)
                if (row.Cells["SoLuong3"].Value != null)
                {
                    int tonKho;
                    if (int.TryParse(row.Cells["SoLuong3"].Value.ToString(), out tonKho))
                    {
                        // Nếu số lượng tồn kho thấp hơn 15, tô màu đỏ nhạt để cảnh báo
                        if (tonKho < 15)
                        {
                            row.DefaultCellStyle.BackColor = Color.MistyRose;
                            row.DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}