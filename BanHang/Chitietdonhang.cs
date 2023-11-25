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
    public partial class Chitietdonhang : Form
    {
        DataQLBHDataContext db = new DataQLBHDataContext();
        Table<Menu> menus;
        Table<HoaDon> hoaDons;
        Table<CTHD> cTHDs;
        Table<GioHang> gioHangs;
        Table<KhachHang> khachHangs;
        
        public Chitietdonhang()
        {
            InitializeComponent();
        }

        public string ma;

        private void Chitietdonhang_Load(object sender, EventArgs e)
        {
            CTHD cthd = new CTHD();
            cTHDs = db.GetTable<CTHD>();
            Menu menu = new Menu();
            menus = db.GetTable<Menu>();

            FrmMuaHang mh = new FrmMuaHang();

            string mhd = FrmMuaHang.mahd;
            var chitiet = from ct in cTHDs
                          join mnu in menus
                          on ct.MaSP equals mnu.MaSP
                          where ct.MaHD == ma
                          select new { ct, mnu };
            int hang = 0;
            int dcao = 100;
            foreach (var ht in chitiet)
            {
                Label tensp = new Label();
                tensp.Text = ht.mnu.TenSP;
                tensp.Visible = true;
                tensp.Size = new Size(400, 100);
                tensp.Font = new Font(Font.FontFamily, 16);
                tableChiTiet.Controls.Add(tensp, 0, hang);
                

                PictureBox pic = new PictureBox();
                string ha = ht.mnu.HinhAnh.Trim();
                string path = "C:\\Users\\MINH QUANG\\OneDrive\\Documents\\LamViecNhom\\BanHang\\BanHang\\hinhanh\\" + ha;
                pic.Image = Image.FromFile(path);
                pic.Width *= 3;
                pic.Height *= 3;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                tableChiTiet.Controls.Add(pic, 1, hang);


                Label sl = new Label();
                sl.Text = ht.ct.SoLuong.ToString();
                sl.Size = new System.Drawing.Size(50, 100);
                sl.Visible = true;
                sl.Font = new Font(Font.FontFamily, 16);
                tableChiTiet.Controls.Add(sl, 2, hang);

                Label gia = new Label();
                gia.Text = ht.mnu.Gia.ToString();
                gia.Visible = true;
                gia.Size = new System.Drawing.Size(100, 100);
                gia.Font = new Font(Font.FontFamily, 16);
                tableChiTiet.Controls.Add(gia, 3, hang);

                hang++;
                dcao = dcao + 200;
            }
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmMuaHang mh = new FrmMuaHang();
            this.Hide();
            mh.Show();
        }
    }
}
