using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang
{
    public partial class QuanTriVien : Form
    {
        DataQLBHDataContext db = new DataQLBHDataContext();
        Table<Menu> menus;
        Table<HoaDon> hoaDons;
        Table<CTHD> cTHDs;
        Table<GioHang> gioHangs;
        Table<KhachHang> khachHangs;
        Table<TrangThai> trangThais;

        public QuanTriVien()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();

            var kt = from mnu in menus
                     where mnu.MaSP == txbMaSP.Text
                     select mnu;

            foreach(var tt in kt)
            {
                txbTenSP.Text = tt.TenSP;
                txbSoLuong.Text = tt.SoLuong.ToString();
                txbGia.Text = tt.Gia.ToString();
                cboLoai.SelectedItem = tt.Loai;

                string path = "C:\\Users\\MINH QUANG\\OneDrive\\Documents\\LamViecNhom\\BanHang\\BanHang\\hinhanh\\" + tt.HinhAnh;
                pictureBox1.Image = Image.FromFile(path);

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private string tenHA;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;

                fileName = dlg.FileName;
                MessageBox.Show(fileName.Substring(75));
                tenHA = fileName.Substring(75);
                //btnHinhAnh.Text = fileName;
                string path = "C:\\Users\\MINH QUANG\\OneDrive\\Documents\\LamViecNhom\\BanHang\\BanHang\\hinhanh\\" + tenHA;
                pictureBox1.Image = Image.FromFile(path);

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();

            var kt = from mnu in menus
                     select mnu;
            int stt = 1;
            foreach(var tt in kt)
            {
                stt++;
            }

            mn.STT = stt;
            mn.MaSP = txbMaSP.Text;
            mn.TenSP = txbTenSP.Text;
            mn.SoLuong = Convert.ToInt32(txbSoLuong.Text);
            mn.Gia = Convert.ToInt32(txbGia.Text);
            mn.Loai = cboLoai.SelectedItem.ToString();
            mn.HinhAnh = tenHA;

            menus.InsertOnSubmit(mn);
            db.SubmitChanges();
            MessageBox.Show("Thêm thành công");

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();

            var kt = from mnu in menus
                     where mnu.MaSP == txbMaSP.Text
                     select mnu;

            foreach(var tt in kt)
            {
                tt.STT = 1;
                //tt.MaSP = txbMaSP.Text;
                tt.TenSP = txbTenSP.Text;
                tt.SoLuong = Convert.ToInt32(txbSoLuong.Text);
                tt.Gia = Convert.ToInt32(txbGia.Text);
                tt.Loai = cboLoai.SelectedItem.ToString();
            }
            db.SubmitChanges();
            MessageBox.Show("Sửa thành công");
        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hoaDons = db.GetTable<HoaDon>();

            var kt1 = from hdn in hoaDons
                      where dateBatDau.Value.Day == hdn.NgayBan.Day
                      select hdn;

            int sl = 0;

            foreach (var tt1 in kt1)
            {
                sl++;
            }

            var tk = from hdon in hoaDons
                     where dateBatDau.Value.Day == hdon.NgayBan.Day
                     group hdon by hdon.NgayBan.Day
                     into g
                     select new {Ngay=dateBatDau.Value.Day, TongHoaDon = sl, TongTien = g.Sum(hdon => hdon.TongTien) };

            dataThongKe.DataSource = tk;
            tabThongKe.Controls.Add(dataThongKe);
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hoaDons = db.GetTable<HoaDon>();

            var kt1 = from hdn in hoaDons
                      where dateBatDau.Value.Month == hdn.NgayBan.Month
                      select hdn;

            int sl = 0;

            foreach (var tt1 in kt1)
            {
                sl++;
            }

            var tk = from hdon in hoaDons
                     where dateBatDau.Value.Month == hdon.NgayBan.Month
                     group hdon by hdon.NgayBan.Month
                     into g
                     select new {Thang=dateBatDau.Value.Month, TongHoaDon = sl, TongTien = g.Sum(hdon => hdon.TongTien) };

            dataThongKe.DataSource = tk;
            tabThongKe.Controls.Add(dataThongKe);
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hoaDons = db.GetTable<HoaDon>();

            var kt1 = from hdn in hoaDons
                      where dateBatDau.Value.Year == hdn.NgayBan.Year
                      select hdn;

            int sl = 0;

            foreach (var tt1 in kt1)
            {
                sl++;
            }

            var tk = from hdon in hoaDons
                     where dateBatDau.Value.Year == hdon.NgayBan.Year
                     group hdon by hdon.NgayBan.Year
                     into g
                     select new { Nam = dateBatDau.Value.Year, TongHoaDon = sl, TongTien = g.Sum(hdon => hdon.TongTien) };

            dataThongKe.DataSource = tk;
            tabThongKe.Controls.Add(dataThongKe);


        }

        private void QuanTriVien_Load(object sender, EventArgs e)
        {

            GioHang gh = new GioHang();
            HoaDon hd = new HoaDon();
            KhachHang kh = new KhachHang();
            Menu menu = new Menu();
            TrangThai trangthai = new TrangThai();
            gioHangs = db.GetTable<GioHang>();
            hoaDons = db.GetTable<HoaDon>();
            khachHangs = db.GetTable<KhachHang>();
            menus = db.GetTable<Menu>();
            trangThais = db.GetTable<TrangThai>();

            var tkhd = from hdon in hoaDons
                       where hdon.MaKH == "KH1"
                       select hdon;
            int sohd = 0;

            foreach (var stt in tkhd)
            {
                sohd++;
            }

            var tkhd1 = from hdon in hoaDons
                        join khang in khachHangs
                        on hdon.MaKH equals khang.MaKH
                        where khang.MaKH == "KH1"
                        select new { hdon, khang };



            int hang = 0;
            tableDonHang.Location = new Point(0, 200);
            tableDonHang.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30F));
            tableDonHang.AutoScroll = true;
            int ttu = 0;

            foreach (var tt in tkhd1)
            {
                Label tenhd = new Label();
                tenhd.Text = tt.hdon.MaHD;
                tenhd.Visible = true;
                tableDonHang.Controls.Add(tenhd, 0, hang);

                Label khg = new Label();
                khg.Text = tt.khang.HoTen;
                khg.Size = new System.Drawing.Size(160, 30);
                khg.Visible = true;
                tableDonHang.Controls.Add(khg, 1, hang);

                Label tg = new Label();
                tg.Text = tt.hdon.NgayBan.ToString();
                tg.Size = new System.Drawing.Size(160, 30);
                tg.Visible = true;
                tableDonHang.Controls.Add(tg, 2, hang);

                Label dc = new Label();
                dc.Text = tt.khang.DiaChi;
                dc.Size = new System.Drawing.Size(300, 30);
                dc.Visible = true;
                tableDonHang.Controls.Add(dc, 3, hang);

                
                var kt2 = from hdon in hoaDons
                          join ttr in trangThais
                          on hdon.MaHD equals ttr.MaHD
                          where ttr.MaHD == tt.hdon.MaHD
                          select new { hdon, ttr };
                

                foreach (var tt2 in kt2)
                {
                    Label tth = new Label();
                    tth.Text = tt2.ttr.TinhTrang;
                    tth.Visible = true;
                    tableDonHang.Controls.Add(tth, 4, hang);
                }

                Label ttien = new Label();
                ttien.Text = tt.hdon.TongTien.ToString();
                ttien.Visible = true;
                tableDonHang.Controls.Add(ttien, 5, hang);

                hang++;
            }
        }

        string manhap;
        private void txbMa_TextChanged(object sender, EventArgs e)
        {
            manhap = txbMa.Text;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ThayDoiTrangThai tdtt = new ThayDoiTrangThai();
            tdtt.ma = manhap;
            this.Hide();
            tdtt.Show();
        }
    }
}
