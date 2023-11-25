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
    public partial class DangNhap : Form
    {
        DataQLBHDataContext db = new DataQLBHDataContext();
        Table<Menu> menus;
        Table<HoaDon> hoaDons;
        Table<CTHD> cTHDs;
        Table<GioHang> gioHangs;
        Table<KhachHang> khachHangs;
        Table<TrangThai> trangThais;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            khachHangs = db.GetTable<KhachHang>();
            KhachHang tt = new KhachHang();
            var query = from ttkh in khachHangs
                        where txtTenDangNhap.Text == ttkh.TenDangNhap
                        where txtMatKhau.Text == ttkh.MatKhau
                        select ttkh;
            int i = 0;
            foreach (var kh in query)
            {
                FrmMuaHang mh = new FrmMuaHang();
                MessageBox.Show("Đăng nhập thành công");
                mh.mkh = kh.MaKH;
                mh.Show();
                //DoiMatKhau dmk = new DoiMatKhau();
                //dmk.mkh = kh.MaKH;
                //dmk.mk = kh.MatKhau;
                //dmk.Show();
                this.Hide();
                i++;
            }
            if (i == 0 && (txtTenDangNhap.Text != "Admin" && txtMatKhau.Text != "1234"))
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");

            if (txtTenDangNhap.Text == "Admin" && txtMatKhau.Text == "1234")
            {
                QuanTriVien qtv = new QuanTriVien();
                qtv.Show();
                this.Hide();
            }
        }
    }
}
