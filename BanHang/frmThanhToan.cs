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
    public partial class frmThanhToan : Form
    {
        DataQLBHDataContext db = new DataQLBHDataContext();
        Table<Menu> menus;
        Table<HoaDon> hoaDons;
        Table<CTHD> cTHDs;
        Table<GioHang> gioHangs;
        Table<KhachHang> khachHangs;
        Table<TrangThai> trangThais;
        int i = 0;
        public string mkhh;
        public int slhd;
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            cTHDs = db.GetTable<CTHD>();
            hoaDons = db.GetTable<HoaDon>();
            menus = db.GetTable<Menu>();
            khachHangs = db.GetTable<KhachHang>();

            var sl = from hd in hoaDons
                     select hd;
            foreach (var stt in sl)
            {
                i++;
            }
            string mahd = "HD" + slhd;

            var ngay = from hd in hoaDons
                       where hd.MaHD == mahd
                       select hd;
            foreach (var ng in ngay)
            {
                txtNgay.Text = ng.NgayBan.ToString();
                txtTongCong.Text = ng.TongTien.ToString();
            }

            var kttt = from kh in khachHangs
                       where kh.MaKH == mkhh
                       select kh;
            foreach (var tt in kttt)
            {
                txtHoTen.Text = tt.HoTen;
                txtSDT.Text = tt.SoDT;
                txtDiaChi.Text = tt.DiaChi;
            }

            var query = from cthd in cTHDs
                        join mnu in menus
                        on cthd.MaSP equals mnu.MaSP
                        where cthd.MaHD == mahd
                        select new
                        {
                            TenMon = mnu.TenSP,
                            Gia = cthd.Gia,
                            SoLuong = cthd.SoLuong,
                            TongTien = cthd.Gia * cthd.SoLuong
                        };
            data.DataSource = query;
        }
    }
}
