
namespace BanHang
{
    partial class QuanTriVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.tabDonHang = new System.Windows.Forms.TabPage();
            this.tabQuanLy = new System.Windows.Forms.TabPage();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.lbHinhAnh = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbLoai = new System.Windows.Forms.Label();
            this.txbMaSP = new System.Windows.Forms.TextBox();
            this.txbTenSP = new System.Windows.Forms.TextBox();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.btnNgay = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.dataThongKe = new System.Windows.Forms.DataGridView();
            this.tableDonHang = new System.Windows.Forms.TableLayoutPanel();
            this.lbmaHD = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbKH = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbNhapMa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.tabDonHang.SuspendLayout();
            this.tabQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabThongKe);
            this.tabControl1.Controls.Add(this.tabQuanLy);
            this.tabControl1.Controls.Add(this.tabDonHang);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 707);
            this.tabControl1.TabIndex = 0;
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.dataThongKe);
            this.tabThongKe.Controls.Add(this.btnNam);
            this.tabThongKe.Controls.Add(this.btnThang);
            this.tabThongKe.Controls.Add(this.btnNgay);
            this.tabThongKe.Controls.Add(this.lbThoiGian);
            this.tabThongKe.Controls.Add(this.dateBatDau);
            this.tabThongKe.Location = new System.Drawing.Point(4, 29);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongKe.Size = new System.Drawing.Size(1243, 674);
            this.tabThongKe.TabIndex = 0;
            this.tabThongKe.Text = "Thống kê";
            this.tabThongKe.UseVisualStyleBackColor = true;
            // 
            // tabDonHang
            // 
            this.tabDonHang.Controls.Add(this.txbMa);
            this.tabDonHang.Controls.Add(this.btnChiTiet);
            this.tabDonHang.Controls.Add(this.label2);
            this.tabDonHang.Controls.Add(this.lbNhapMa);
            this.tabDonHang.Controls.Add(this.lbTongTien);
            this.tabDonHang.Controls.Add(this.lbTrangThai);
            this.tabDonHang.Controls.Add(this.lbDiaChi);
            this.tabDonHang.Controls.Add(this.lbKH);
            this.tabDonHang.Controls.Add(this.lbNgay);
            this.tabDonHang.Controls.Add(this.lbmaHD);
            this.tabDonHang.Controls.Add(this.tableDonHang);
            this.tabDonHang.Location = new System.Drawing.Point(4, 29);
            this.tabDonHang.Name = "tabDonHang";
            this.tabDonHang.Size = new System.Drawing.Size(1243, 674);
            this.tabDonHang.TabIndex = 2;
            this.tabDonHang.Text = "Đơn hàng";
            this.tabDonHang.UseVisualStyleBackColor = true;
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Controls.Add(this.panel1);
            this.tabQuanLy.Controls.Add(this.btnLuu);
            this.tabQuanLy.Controls.Add(this.btnTim);
            this.tabQuanLy.Controls.Add(this.btnThem);
            this.tabQuanLy.Controls.Add(this.cboLoai);
            this.tabQuanLy.Controls.Add(this.txbGia);
            this.tabQuanLy.Controls.Add(this.txbSoLuong);
            this.tabQuanLy.Controls.Add(this.txbTenSP);
            this.tabQuanLy.Controls.Add(this.txbMaSP);
            this.tabQuanLy.Controls.Add(this.lbLoai);
            this.tabQuanLy.Controls.Add(this.lbGia);
            this.tabQuanLy.Controls.Add(this.lbSoLuong);
            this.tabQuanLy.Controls.Add(this.lbTenSP);
            this.tabQuanLy.Controls.Add(this.lbHinhAnh);
            this.tabQuanLy.Controls.Add(this.lbMaSP);
            this.tabQuanLy.Controls.Add(this.lbThongTin);
            this.tabQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabQuanLy.Location = new System.Drawing.Point(4, 29);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLy.Size = new System.Drawing.Size(1243, 674);
            this.tabQuanLy.TabIndex = 1;
            this.tabQuanLy.Text = "Quản lý";
            this.tabQuanLy.UseVisualStyleBackColor = true;
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThongTin.Location = new System.Drawing.Point(36, 34);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(296, 36);
            this.lbThongTin.TabIndex = 0;
            this.lbThongTin.Text = "Thông tin sản phẩm";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaSP.Location = new System.Drawing.Point(140, 115);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(121, 20);
            this.lbMaSP.TabIndex = 1;
            this.lbMaSP.Text = "Mã sản phẩm";
            // 
            // lbHinhAnh
            // 
            this.lbHinhAnh.AutoSize = true;
            this.lbHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHinhAnh.Location = new System.Drawing.Point(140, 193);
            this.lbHinhAnh.Name = "lbHinhAnh";
            this.lbHinhAnh.Size = new System.Drawing.Size(84, 20);
            this.lbHinhAnh.TabIndex = 2;
            this.lbHinhAnh.Text = "Hình ảnh";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenSP.Location = new System.Drawing.Point(143, 333);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(127, 20);
            this.lbTenSP.TabIndex = 3;
            this.lbTenSP.Text = "Tên sản phẩm";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoLuong.Location = new System.Drawing.Point(146, 409);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(82, 20);
            this.lbSoLuong.TabIndex = 4;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGia.Location = new System.Drawing.Point(146, 478);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(38, 20);
            this.lbGia.TabIndex = 5;
            this.lbGia.Text = "Giá";
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoai.Location = new System.Drawing.Point(143, 553);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(45, 20);
            this.lbLoai.TabIndex = 6;
            this.lbLoai.Text = "Loại";
            // 
            // txbMaSP
            // 
            this.txbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbMaSP.Location = new System.Drawing.Point(411, 115);
            this.txbMaSP.Name = "txbMaSP";
            this.txbMaSP.Size = new System.Drawing.Size(311, 27);
            this.txbMaSP.TabIndex = 7;
            // 
            // txbTenSP
            // 
            this.txbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTenSP.Location = new System.Drawing.Point(411, 327);
            this.txbTenSP.Name = "txbTenSP";
            this.txbTenSP.Size = new System.Drawing.Size(311, 27);
            this.txbTenSP.TabIndex = 8;
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSoLuong.Location = new System.Drawing.Point(411, 409);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(311, 27);
            this.txbSoLuong.TabIndex = 9;
            // 
            // txbGia
            // 
            this.txbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbGia.Location = new System.Drawing.Point(411, 478);
            this.txbGia.Name = "txbGia";
            this.txbGia.Size = new System.Drawing.Size(311, 27);
            this.txbGia.TabIndex = 10;
            // 
            // cboLoai
            // 
            this.cboLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "Gấu ",
            "Đồng hồ",
            "Hộp nhạc",
            "Pha lê",
            "Quả cầu tuyết"});
            this.cboLoai.Location = new System.Drawing.Point(411, 553);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(311, 28);
            this.cboLoai.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(800, 549);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 34);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTim.Location = new System.Drawing.Point(820, 115);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(105, 35);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(977, 549);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 34);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 147);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(425, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 147);
            this.panel1.TabIndex = 18;
            // 
            // dateBatDau
            // 
            this.dateBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateBatDau.Location = new System.Drawing.Point(416, 81);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(235, 28);
            this.dateBatDau.TabIndex = 0;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThoiGian.Location = new System.Drawing.Point(92, 81);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(98, 24);
            this.lbThoiGian.TabIndex = 2;
            this.lbThoiGian.Text = "Thời gian";
            // 
            // btnNgay
            // 
            this.btnNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNgay.Location = new System.Drawing.Point(78, 242);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(240, 42);
            this.btnNgay.TabIndex = 3;
            this.btnNgay.Text = "Lọc Theo Ngày";
            this.btnNgay.UseVisualStyleBackColor = false;
            this.btnNgay.Click += new System.EventHandler(this.btnNgay_Click);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThang.Location = new System.Drawing.Point(416, 242);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(240, 42);
            this.btnThang.TabIndex = 4;
            this.btnThang.Text = "Lọc Theo Tháng";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNam.Location = new System.Drawing.Point(746, 242);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(240, 42);
            this.btnNam.TabIndex = 5;
            this.btnNam.Text = "Lọc Theo Năm";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // dataThongKe
            // 
            this.dataThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThongKe.Location = new System.Drawing.Point(78, 344);
            this.dataThongKe.Name = "dataThongKe";
            this.dataThongKe.RowHeadersWidth = 51;
            this.dataThongKe.RowTemplate.Height = 24;
            this.dataThongKe.Size = new System.Drawing.Size(908, 238);
            this.dataThongKe.TabIndex = 6;
            // 
            // tableDonHang
            // 
            this.tableDonHang.ColumnCount = 6;
            this.tableDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.76433F));
            this.tableDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.23567F));
            this.tableDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableDonHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableDonHang.Location = new System.Drawing.Point(0, 159);
            this.tableDonHang.Name = "tableDonHang";
            this.tableDonHang.RowCount = 3;
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.22222F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.77778F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableDonHang.Size = new System.Drawing.Size(1096, 428);
            this.tableDonHang.TabIndex = 0;
            // 
            // lbmaHD
            // 
            this.lbmaHD.AutoSize = true;
            this.lbmaHD.Location = new System.Drawing.Point(3, 116);
            this.lbmaHD.Name = "lbmaHD";
            this.lbmaHD.Size = new System.Drawing.Size(106, 20);
            this.lbmaHD.TabIndex = 1;
            this.lbmaHD.Text = "Mã hóa đơn";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(318, 116);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(92, 20);
            this.lbNgay.TabIndex = 2;
            this.lbNgay.Text = "Ngày mua";
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Location = new System.Drawing.Point(131, 116);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(107, 20);
            this.lbKH.TabIndex = 3;
            this.lbKH.Text = "Khách hàng";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(548, 116);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(68, 20);
            this.lbDiaChi.TabIndex = 4;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Location = new System.Drawing.Point(805, 116);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(94, 20);
            this.lbTrangThai.TabIndex = 5;
            this.lbTrangThai.Text = "Trạng thái";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(971, 116);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(87, 20);
            this.lbTongTien.TabIndex = 6;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // lbNhapMa
            // 
            this.lbNhapMa.AutoSize = true;
            this.lbNhapMa.Location = new System.Drawing.Point(180, 41);
            this.lbNhapMa.Name = "lbNhapMa";
            this.lbNhapMa.Size = new System.Drawing.Size(106, 20);
            this.lbNhapMa.TabIndex = 7;
            this.lbNhapMa.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChiTiet.Location = new System.Drawing.Point(787, 34);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(156, 31);
            this.btnChiTiet.TabIndex = 9;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(446, 38);
            this.txbMa.Name = "txbMa";
            this.txbMa.Size = new System.Drawing.Size(239, 27);
            this.txbMa.TabIndex = 10;
            this.txbMa.TextChanged += new System.EventHandler(this.txbMa_TextChanged);
            // 
            // QuanTriVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 629);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanTriVien";
            this.Text = "QuanTriVien";
            this.Load += new System.EventHandler(this.QuanTriVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabThongKe.ResumeLayout(false);
            this.tabThongKe.PerformLayout();
            this.tabDonHang.ResumeLayout(false);
            this.tabDonHang.PerformLayout();
            this.tabQuanLy.ResumeLayout(false);
            this.tabQuanLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.TabPage tabDonHang;
        private System.Windows.Forms.TabPage tabQuanLy;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbHinhAnh;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.TextBox txbTenSP;
        private System.Windows.Forms.TextBox txbMaSP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataThongKe;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.TableLayoutPanel tableDonHang;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbmaHD;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNhapMa;
    }
}