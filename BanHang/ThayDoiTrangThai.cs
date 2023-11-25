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
    public partial class ThayDoiTrangThai : Form
    {

        DataQLBHDataContext db = new DataQLBHDataContext();
        Table<Menu> menus;
        Table<HoaDon> hoaDons;
        Table<CTHD> cTHDs;
        Table<GioHang> gioHangs;
        Table<KhachHang> khachHangs;
        Table<TrangThai> trangThais;
        public ThayDoiTrangThai()
        {
            InitializeComponent();
        }

        public string ma;
        private void ThayDoiTrangThai_Load(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            TrangThai tt = new TrangThai();
            hoaDons = db.GetTable<HoaDon>();
            trangThais = db.GetTable<TrangThai>();

            var chitiet = from hdn in hoaDons
                          join ttr in trangThais
                          on hdn.MaHD equals ttr.MaHD
                          where ttr.MaHD == ma
                          select new { hdn, ttr };

            foreach(var tth in chitiet)
            {
                txbMa.Text = tth.ttr.MaHD;
                cboTrangThai.SelectedItem = tth.ttr.TinhTrang;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TrangThai tt = new TrangThai();
            trangThais = db.GetTable<TrangThai>();

            var kt = from ttr in trangThais
                     where ttr.MaHD == txbMa.Text
                     select ttr;

            foreach (var ttu in kt)
            {
                if (ttu.TinhTrang == "Đã giao" && cboTrangThai.SelectedItem == "Đang giao")
                    MessageBox.Show("Không thể thay đổi trang thái đơn hàng");
                else if(ttu.TinhTrang=="Đã giao" && cboTrangThai.SelectedItem == "Đã hủy")
                    MessageBox.Show("Không thể thay đổi trang thái đơn hàng");
                else if (ttu.TinhTrang == "Đã giao" && cboTrangThai.SelectedItem == "Chờ xác nhận")
                    MessageBox.Show("Không thể thay đổi trang thái đơn hàng");
                else if (ttu.TinhTrang == "Chờ xác nhận" && cboTrangThai.SelectedItem == "Đang giao")
                    MessageBox.Show("Không thể thay đổi trang thái đơn hàng");
                else if(ttu.TinhTrang == "Đang giao" && cboTrangThai.SelectedItem == "Đã hủy")
                    MessageBox.Show("Không thể thay đổi trang thái đơn hàng");
                else if (ttu.TinhTrang == "Đang giao" && cboTrangThai.SelectedItem == "Chờ xác nhận")
                    MessageBox.Show("Không thể thay đổi trang thái đơn hàng");
                else if (ttu.TinhTrang == "Đã hủy" && cboTrangThai.SelectedItem == "Chờ xác nhận")
                    MessageBox.Show("Không thể thay đổi trang thái đơn hàng");
                else if (ttu.TinhTrang == "Đã hủy" && cboTrangThai.SelectedItem == "Đang giao")
                    MessageBox.Show("Không thể thay đổi trang thái đơn hàng");
                else if (ttu.TinhTrang == "Đã hủy" && cboTrangThai.SelectedItem == "Đã giao")
                    MessageBox.Show("Không thể thay đổi trang thái đơn hàng");
                else
                {
                    ttu.MaHD = txbMa.Text;
                    ttu.TinhTrang = cboTrangThai.SelectedItem.ToString();
                    db.SubmitChanges();
                    MessageBox.Show("Thay đổi trạng thái đơn hàng thành công");
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            QuanTriVien qtv = new QuanTriVien();
            this.Hide();
            qtv.Show();
        }
    }
}
