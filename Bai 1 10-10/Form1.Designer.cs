namespace Bai_1_10_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpThongTin = new GroupBox();
            txtXacNhan = new TextBox();
            lblXacNhan = new Label();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            grpBoSung = new GroupBox();
            chkDieuKhoan = new CheckBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            lblGioiTinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            btnDangKy = new Button();
            btnLamMoi = new Button();
            epCheck = new ErrorProvider(components);
            grpThongTin.SuspendLayout();
            grpBoSung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            //
            // grpThongTin
            //
            grpThongTin.Controls.Add(txtXacNhan);
            grpThongTin.Controls.Add(lblXacNhan);
            grpThongTin.Controls.Add(txtMatKhau);
            grpThongTin.Controls.Add(lblMatKhau);
            grpThongTin.Controls.Add(txtTenDangNhap);
            grpThongTin.Controls.Add(lblTenDangNhap);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(460, 150);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin cá nhân";
            //
            // txtXacNhan
            //
            txtXacNhan.Location = new Point(150, 105);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(290, 27);
            txtXacNhan.TabIndex = 5;
            txtXacNhan.UseSystemPasswordChar = true;
            //
            // lblXacNhan
            //
            lblXacNhan.AutoSize = true;
            lblXacNhan.Location = new Point(15, 108);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.Size = new Size(130, 20);
            lblXacNhan.TabIndex = 4;
            lblXacNhan.Text = "Xác nhận mật khẩu";
            //
            // txtMatKhau
            //
            txtMatKhau.Location = new Point(150, 68);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(290, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            //
            // lblMatKhau
            //
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(15, 71);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(70, 20);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu";
            //
            // txtTenDangNhap
            //
            txtTenDangNhap.Location = new Point(150, 31);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(290, 27);
            txtTenDangNhap.TabIndex = 1;
            //
            // lblTenDangNhap
            //
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(15, 34);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(107, 20);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập";
            //
            // grpBoSung
            //
            grpBoSung.Controls.Add(chkDieuKhoan);
            grpBoSung.Controls.Add(radNu);
            grpBoSung.Controls.Add(radNam);
            grpBoSung.Controls.Add(lblGioiTinh);
            grpBoSung.Controls.Add(dtpNgaySinh);
            grpBoSung.Controls.Add(lblNgaySinh);
            grpBoSung.Location = new Point(12, 168);
            grpBoSung.Name = "grpBoSung";
            grpBoSung.Size = new Size(460, 150);
            grpBoSung.TabIndex = 1;
            grpBoSung.TabStop = false;
            grpBoSung.Text = "Thông tin bổ sung";
            //
            // chkDieuKhoan
            //
            chkDieuKhoan.AutoSize = true;
            chkDieuKhoan.Location = new Point(150, 108);
            chkDieuKhoan.Name = "chkDieuKhoan";
            chkDieuKhoan.Size = new Size(200, 24);
            chkDieuKhoan.TabIndex = 5;
            chkDieuKhoan.Text = "Đồng ý điều khoản dịch vụ";
            chkDieuKhoan.UseVisualStyleBackColor = true;
            //
            // radNu
            //
            radNu.AutoSize = true;
            radNu.Location = new Point(240, 71);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 4;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            //
            // radNam
            //
            radNam.AutoSize = true;
            radNam.Checked = true;
            radNam.Location = new Point(150, 71);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 3;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            //
            // lblGioiTinh
            //
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(15, 73);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 20);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.Text = "Giới tính";
            //
            // dtpNgaySinh
            //
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(150, 31);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(290, 27);
            dtpNgaySinh.TabIndex = 1;
            //
            // lblNgaySinh
            //
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(15, 36);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(74, 20);
            lblNgaySinh.TabIndex = 0;
            lblNgaySinh.Text = "Ngày sinh";
            //
            // btnDangKy
            //
            btnDangKy.Location = new Point(120, 335);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(110, 35);
            btnDangKy.TabIndex = 2;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            //
            // btnLamMoi
            //
            btnLamMoi.Location = new Point(255, 335);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 35);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            //
            // epCheck
            //
            epCheck.ContainerControl = this;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 391);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDangKy);
            Controls.Add(grpBoSung);
            Controls.Add(grpThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpBoSung.ResumeLayout(false);
            grpBoSung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTin;
        private TextBox txtXacNhan;
        private Label lblXacNhan;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private TextBox txtTenDangNhap;
        private Label lblTenDangNhap;
        private GroupBox grpBoSung;
        private CheckBox chkDieuKhoan;
        private RadioButton radNu;
        private RadioButton radNam;
        private Label lblGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblNgaySinh;
        private Button btnDangKy;
        private Button btnLamMoi;
        private ErrorProvider epCheck;
    }
}
