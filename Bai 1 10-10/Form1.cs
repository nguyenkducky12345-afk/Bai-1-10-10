namespace Bai_1_10_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ thông báo lỗi cũ trước khi kiểm tra lại
            epCheck.Clear();

            bool hopLe = true;

            // 1. Tên đăng nhập không được để trống
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                epCheck.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
                hopLe = false;
            }

            // 2. Mật khẩu không được để trống
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                epCheck.SetError(txtMatKhau, "Mật khẩu không được để trống!");
                hopLe = false;
            }

            // 3. Mật khẩu nhập lại phải khớp với mật khẩu ban đầu
            if (txtXacNhan.Text != txtMatKhau.Text)
            {
                epCheck.SetError(txtXacNhan, "Mật khẩu nhập lại không khớp!");
                hopLe = false;
            }

            // 4. Tuổi tính từ ngày sinh phải >= 18
            int tuoi = DateTime.Today.Year - dtpNgaySinh.Value.Year;
            if (dtpNgaySinh.Value.Date > DateTime.Today.AddYears(-tuoi))
                tuoi--;

            if (tuoi < 18)
            {
                epCheck.SetError(dtpNgaySinh, "Bạn phải đủ 18 tuổi trở lên!");
                hopLe = false;
            }

            // 5. Phải tích chọn đồng ý điều khoản dịch vụ
            if (!chkDieuKhoan.Checked)
            {
                epCheck.SetError(chkDieuKhoan, "Bạn phải đồng ý điều khoản dịch vụ!");
                hopLe = false;
            }

            // Nếu tất cả hợp lệ thì thông báo thành công
            if (hopLe)
            {
                string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
                MessageBox.Show(
                    $"Đăng ký thành công!\n\nTên đăng nhập: {txtTenDangNhap.Text}\nGiới tính: {gioiTinh}\nNgày sinh: {dtpNgaySinh.Value:dd/MM/yyyy}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa lỗi ErrorProvider và đưa các control về trạng thái ban đầu
            epCheck.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtXacNhan.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            radNam.Checked = true;
            chkDieuKhoan.Checked = false;
            txtTenDangNhap.Focus();
        }
    }
}
