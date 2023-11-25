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
    public partial class FrmMuaHang : Form
    {
        DataQLBHDataContext db = new DataQLBHDataContext();
        Table<Menu> menus;
        Table<HoaDon> hoaDons;
        Table<CTHD> cTHDs;
        Table<GioHang> gioHangs;
        Table<KhachHang> khachHangs;
        Table<TrangThai> trangThais;
        
        int i = 1;
        string ten;
        static public string mahd;
        public string mkh;

        int[] listtinh = new int[100];
        private ListBox listBox = new ListBox();
        private int ttsp = 0;

        private int[] gban = new int[100];

        public FrmMuaHang()
        {
            InitializeComponent();
        }

        public void loadMon(string loai)
        {
            menus = db.GetTable<Menu>();
            var query = from mn in menus
                        where mn.Loai == loai
                        select new { ten = mn.TenSP, ma = mn.MaSP };
            foreach (var tv in query)
            {
                List<string> mon = new List<string>();
                foreach (var m in query)
                {
                    string ma = m.ten;
                    mon.Add(ma);
                }
            }

            cboTen.DataSource = query;
            cboTen.DisplayMember = "ten";
            cboTen.ValueMember = "ma";
        }


        private void FrmMuaHang_Load(object sender, EventArgs e)
        {
            //HoaDon hd = new HoaDon();
            //hoaDons = db.GetTable<HoaDon>();

            GioHang gh = new GioHang();
            HoaDon hd = new HoaDon();
            KhachHang kh = new KhachHang();
            Menu menu = new Menu();
            gioHangs = db.GetTable<GioHang>();
            hoaDons = db.GetTable<HoaDon>();
            khachHangs = db.GetTable<KhachHang>();
            menus = db.GetTable<Menu>();

            DangNhap dn = new DangNhap();

            MessageBox.Show("Mã khách hàng: " + mkh);

            var query = from hD in hoaDons
                        select hD;
            foreach (var kq in query)
            {
                i++;
            }

            hd.MaHD = "HD" + i;
            string ngay = DateTime.Now.ToString();
            hd.NgayBan = Convert.ToDateTime(ngay);
            hd.TongTien = 0;

            //hoaDons.InsertOnSubmit(hd);
            //db.SubmitChanges();

            

            var query1 = from m in gioHangs
                        where m.MaKH == mkh
                        select m;
            int sttgh = 0;

            int ttu = 0;
            tableGioHang.AutoScroll = true;
            tableGioHang.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30F));

            foreach (var ll in query1)
            {
                PictureBox pic = new PictureBox();
                string ha = ll.HinhAnh.Trim();
                string path = "C:\\Users\\MINH QUANG\\OneDrive\\Documents\\LamViecNhom\\BanHang\\BanHang\\hinhanh\\" + ha;
                pic.Image = Image.FromFile(path);
                pic.Width *= 3;
                pic.Height *= 3;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                tableGioHang.Controls.Add(pic, 0, sttgh);

                sttgh++;

                Label ten = new Label();
                ten.Size = new System.Drawing.Size(500, 30);
                ten.Visible = true;
                ten.Text = "Tên sản phẩm: " + ll.TenSP;
                tableGioHang.Controls.Add(ten, 0, sttgh);

                sttgh++;

                Label Gia_SL = new Label();
                Gia_SL.Size = new System.Drawing.Size(300, 30);
                Gia_SL.Visible = true;
                Gia_SL.Text = "Giá: " + ll.Gia.ToString() + " - Số lượng: " + ll.SoLuong.ToString();
                tableGioHang.Controls.Add(Gia_SL, 0, sttgh);

                sttgh++;
            }
            
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            int tien = 0;
            var kt = from ghg in gioHangs
                     where ghg.MaKH == mkh
                     select ghg;
            foreach(var tt in kt)
            {
                tien = tien + tt.Gia * tt.SoLuong;
            }
            txbTongtien_GH.Text = tien.ToString();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();
            loadMon("Gấu");
        }

        private void btnDH_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();
            loadMon("Đồng hồ");
        }

        private void btnHN_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();
            loadMon("Hộp nhạc");
        }

        private void btnPL_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();
            loadMon("Pha lê");
        }

        private void btnQCT_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();
            loadMon("Quả cầu tuyết");
        }

        private void cboTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();
            var query1 = from m1 in menus
                         where m1.MaSP == cboTen.SelectedValue.ToString()
                         select m1;

            foreach (var tv1 in query1)
            {

                List<int> sl = new List<int>();
                for (int i = 0; i <= tv1.SoLuong; i++)
                {
                    sl.Add(i);
                }

                string ha = tv1.HinhAnh.Trim();
                string path = "C:\\Users\\MINH QUANG\\OneDrive\\Documents\\LamViecNhom\\BanHang\\BanHang\\hinhanh\\" + ha;
                picHA.Image = Image.FromFile(path);

                picHA.SizeMode = PictureBoxSizeMode.StretchImage; //Giãn nở kích thước theo PictureBox

                txtGia.Text = tv1.Gia.ToString();
                lstSoLuong.DataSource = sl;
            }
        }

        private void btnTVGH_Click(object sender, EventArgs e)
        {
            GioHang gh = new GioHang();
            Menu mn = new Menu();
            gioHangs = db.GetTable<GioHang>();

            int sl = Convert.ToInt32(lstSoLuong.SelectedItem.ToString());

            //string makh = mkh;
            gh.MaKH = mkh;
            gh.MaSP = cboTen.SelectedValue.ToString();
            var query = from m in menus
                        where m.MaSP == gh.MaSP
                        select m;

            var kt = from ghg in gioHangs
                        select ghg;

            int i = 1;
            foreach(var tt in kt)
            {
               i++;
            }

            string ten="";
            string loai = "";
            string ha = "";
            int gia = 0;
            foreach(var tt in query)
            {
                ten = tt.TenSP;
                loai = tt.Loai;
                ha = tt.HinhAnh;
                gia = tt.Gia;
            }
            gh.STT = i;
            gh.Gia = gia;
            gh.TenSP = ten;
            gh.Loai = loai;
            gh.HinhAnh = ha;

            gh.SoLuong = sl;

            gioHangs.InsertOnSubmit(gh);
            db.SubmitChanges();
            MessageBox.Show("Thêm vào giỏ hàng thành công");
        }
        private void tabMuaSam_Click(object sender, EventArgs e)
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
                       where hdon.MaKH == mkh
                       select hdon;
            int sohd = 0;

            foreach(var stt in tkhd)
            {
                sohd++;
            }

            var tkhd1 = from hdon in hoaDons
                        join khang in khachHangs
                        on hdon.MaKH equals khang.MaKH
                       where khang.MaKH==mkh
                       select new { hdon, khang };

            int hang = 0;
            table1.Location = new Point(0, 200);
            table1.RowStyles.Add(new RowStyle(SizeType.AutoSize, 30F));
            table1.RowCount = 7;
            int ttu = 0;

            foreach (var tt in tkhd1)
            {
                Label tenhd = new Label();
                tenhd.Text = tt.hdon.MaHD;
                tenhd.Visible = true;
                table1.Controls.Add(tenhd, 0, hang);

                Label tg = new Label();
                tg.Text = tt.hdon.NgayBan.ToString();
                tg.Size = new System.Drawing.Size(160, 30);
                tg.Visible = true;
                table1.Controls.Add(tg, 1, hang);

                Label dc = new Label();
                dc.Text = tt.khang.DiaChi;
                dc.Size = new System.Drawing.Size(300, 30);
                dc.Visible = true;
                table1.Controls.Add(dc, 2, hang);

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
                    table1.Controls.Add(tth, 3, hang);
                }

                Label ttien = new Label();
                ttien.Text = tt.hdon.TongTien.ToString();
                ttien.Visible = true;
                table1.Controls.Add(ttien, 4, hang);

                hang++;
                mahd=tt.hdon.MaHD;
            }

            var tk = from m1 in menus
                     select m1;

        }

        public string MaHD()
        {
            return mahd;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            CTHD ct = new CTHD();
            cTHDs = db.GetTable<CTHD>();
            HoaDon hd = new HoaDon();
            hoaDons = db.GetTable<HoaDon>();
            Menu mn = new Menu();
            menus = db.GetTable<Menu>();
            TrangThai tthai = new TrangThai();
            trangThais = db.GetTable<TrangThai>();

            string mahd = "HD" + i;
            string makh = mkh;
            
            int sl = Convert.ToInt32(lstSoLuong.SelectedItem.ToString());
            int gia = Convert.ToInt32(txtGia.Text);
            int tien = sl * gia;

            hd.MaHD = mahd;
            hd.MaKH = makh;
            hd.NgayBan = DateTime.Now;
            hd.TongTien = tien;

            hoaDons.InsertOnSubmit(hd);
            db.SubmitChanges();

            ct.MaHD = mahd;
            ct.MaKH = makh;
            ct.MaSP = cboTen.SelectedValue.ToString();
            ct.SoLuong = Convert.ToInt32(lstSoLuong.SelectedItem.ToString());
            ct.Gia = Convert.ToInt32(txtGia.Text);

            cTHDs.InsertOnSubmit(ct);
            db.SubmitChanges();

            tthai.MaHD = mahd;
            tthai.TinhTrang = "Chờ xác nhận";
            trangThais.InsertOnSubmit(tthai);
            db.SubmitChanges();

            var kt = from mnu in menus
                     where mnu.MaSP == cboTen.SelectedValue.ToString()
                     select mnu;
            foreach (var tt in kt)
            {
                //tt.STT = 1;
                tt.MaSP = cboTen.SelectedValue.ToString();
                int slg = tt.SoLuong - Convert.ToInt32(lstSoLuong.SelectedItem.ToString());
                tt.SoLuong = slg;
            }
            db.SubmitChanges();

            //MessageBox.Show("Thanh toán thành công: " + tien);
            var kthd = from kh in khachHangs
                       where kh.MaKH == mkh
                       select kh;
            foreach(var tt in kthd)
            {
                frmThanhToan ttoan = new frmThanhToan();
                ttoan.mkhh = tt.MaKH;
                ttoan.slhd = i;
                this.Hide();
                ttoan.Show();
            }
        }

        private void btnThanhToan_GH_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            CTHD ct = new CTHD();
            GioHang gh = new GioHang();
            hoaDons = db.GetTable<HoaDon>();
            cTHDs = db.GetTable<CTHD>();
            gioHangs = db.GetTable<GioHang>();
            TrangThai tthai = new TrangThai();
            trangThais = db.GetTable<TrangThai>();

            var kt = from ghg in gioHangs
                     where ghg.MaKH == mkh
                     select ghg;

            int tien = 0;
            foreach(var tt in kt)
            {
                tien = tien + tt.Gia * tt.SoLuong;
            }

            int slhd = 1;
            var kt2 = from hdn in hoaDons
                      select hdn;
            foreach(var tt in kt2)
            {
                slhd++;
            }

            hd.MaHD = "HD" + slhd;
            hd.MaKH = mkh;
            hd.NgayBan = DateTime.Now;
            hd.TongTien = tien;
            hoaDons.InsertOnSubmit(hd);
            db.SubmitChanges();

            
            var kt1 = from mnu in menus
                      select mnu;

            var ktr = from ghg in gioHangs
                      join mnu in menus on ghg.MaSP equals mnu.MaSP
                      where ghg.MaKH == mkh
                      select new { ghg, mnu };
            foreach (var tt1 in ktr)
            {
                string ma = tt1.mnu.MaSP;
                var kq = from men in menus
                         where men.MaSP == ma
                         select men;
                foreach (var tt in kq)
                {
                    tt.SoLuong = Convert.ToInt32(tt.SoLuong) - Convert.ToInt32(tt1.ghg.SoLuong);
                }
                db.SubmitChanges();
            }

            foreach (var tt in kt)
            {
                CTHD ctn = new CTHD(); // Tạo một đối tượng mới ở mỗi lần lặp
                ctn.MaHD = "HD" + slhd;
                ctn.MaKH = tt.MaKH;
                ctn.MaSP = tt.MaSP;
                ctn.SoLuong = tt.SoLuong;
                ctn.Gia = tt.Gia;
                cTHDs.InsertOnSubmit(ctn);
            }
            db.SubmitChanges();
            
            foreach (var tt in kt)
            {
                gioHangs.DeleteOnSubmit(tt);
            }
            db.SubmitChanges();
            

            tthai.MaHD = "HD" + slhd;
            tthai.TinhTrang = "Chờ xác nhận";
            trangThais.InsertOnSubmit(tthai);
            db.SubmitChanges();

            var kthd = from kh in khachHangs
                       where kh.MaKH == mkh
                       select kh;
            foreach (var tt in kthd)
            {
                frmThanhToan ttoan = new frmThanhToan();
                ttoan.mkhh = tt.MaKH;
                ttoan.slhd = slhd;
                this.Hide();
                ttoan.Show();
            }
        }

        string manhap="";

        private void txbNhapMaHD_TextChanged(object sender, EventArgs e)
        {
            CTHD ct = new CTHD();
            cTHDs = db.GetTable<CTHD>();

            manhap = txbNhapMaHD.Text;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            Chitietdonhang ctdh = new Chitietdonhang();
            ctdh.ma = manhap;
            this.Hide();
            ctdh.Show();
        }

        //public string mkh;
        public string mk;
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            khachHangs = db.GetTable<KhachHang>();

            var kt = from khg in khachHangs
                     where khg.MaKH == mkh
                     select khg;

            foreach (var tt in kt)
            {
                string chuoi1 = tt.MatKhau.Replace(" ", "");
                string chuoi2 = txtNhapmatkhaucu.Text;

                if (chuoi1 != chuoi2)
                    MessageBox.Show("Mật khẩu cũ không đúng");
                else
                {
                    if (txtNhapmatkhaumoi.Text != txtNhaplaimatkhau.Text)
                        MessageBox.Show("Mật khẩu không khớp");
                    else
                    {
                        tt.MaKH = mkh;
                        tt.MatKhau = txtNhapmatkhaumoi.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }

                }
            }
            }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.Show();
        }

        private void btnThayDoiThongTin_Click(object sender, EventArgs e)
        {
            khachHangs = db.GetTable<KhachHang>();
            KhachHang tt = new KhachHang();
            var query = from ttkh in khachHangs
                        where ttkh.MaKH == mkh
                        select ttkh;
            int i = 0;
            foreach (var kh in query)
            {
                ThayDoiThongTin ttdt = new ThayDoiThongTin();
                ttdt.mkh = kh.MaKH;
                this.Hide();
                ttdt.Show();
            }
        }
    }
}
