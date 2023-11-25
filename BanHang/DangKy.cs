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
    public partial class DangKy : Form
    {
        DataQLBHDataContext db = new DataQLBHDataContext();
        Table<Menu> menus;
        Table<HoaDon> hoaDons;
        Table<CTHD> cTHDs;
        Table<GioHang> gioHangs;
        Table<KhachHang> khachHangs;
        Table<TrangThai> trangThais;
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            KhachHang tt = new KhachHang();
            khachHangs = db.GetTable<KhachHang>();
            DangNhap dangnhap = new DangNhap();

            int i = 1;
            var query = from kh in khachHangs
                        select kh;
            foreach (var ttkh in query)
            {
                i++;
            }

            List<string> chuoiSDT3 = new List<string>();
            List<string> chuoiSDT4 = new List<string>();
            chuoiSDT3.Add("097");
            chuoiSDT3.Add("098");
            chuoiSDT3.Add("038");
            chuoiSDT3.Add("039");
            chuoiSDT3.Add("036");
            chuoiSDT3.Add("037");
            chuoiSDT3.Add("035");
            chuoiSDT3.Add("090");
            chuoiSDT3.Add("093");
            chuoiSDT3.Add("094");
            chuoiSDT3.Add("091");
            chuoiSDT3.Add("092");
            chuoiSDT3.Add("095");
            chuoiSDT3.Add("096");
            chuoiSDT3.Add("099");

            chuoiSDT4.Add("0122");
            chuoiSDT4.Add("0121");
            chuoiSDT4.Add("0126");
            chuoiSDT4.Add("0128");
            chuoiSDT4.Add("0120");
            chuoiSDT4.Add("0123");
            chuoiSDT4.Add("0125");
            chuoiSDT4.Add("0127");

            var kn = from ttkh in khachHangs
                     where ttkh.SoDT == txtSDT.Text
                     select ttkh;
            int slsdt = 0;
            foreach (var sl in kn)
            {
                slsdt++;
            }


            if (txtHoTen.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == ""
                || txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ");
            }
            else
            {
                if (slsdt == 0)
                {
                    string sdt3 = txtSDT.Text.Substring(0, 3);
                    string sdt4 = txtSDT.Text.Substring(0, 4);
                    int phaisdt = 0;

                    for (int h = 0; h < chuoiSDT3.Count; h++)
                    {
                        if (String.Compare(chuoiSDT3[h], sdt3, true) == 0)
                            phaisdt = 1;
                    }

                    for (int h = 0; h < chuoiSDT4.Count; h++)
                    {
                        if (String.Compare(chuoiSDT4[h], sdt4, true) == 0)
                            phaisdt = 1;
                    }

                    if (phaisdt == 1 && txtSDT.Text.Length == 10)
                    {
                        var mk = from ttkh in khachHangs
                                 where ttkh.TenDangNhap == txtTenDangNhap.Text
                                 select ttkh;
                        int dem = 0;
                        foreach (var kq in mk)
                        {
                            dem++;
                        }
                        if (dem == 0)
                        {
                            tt.MaKH = "KH" + i;
                            tt.HoTen = txtHoTen.Text;
                            tt.SoDT = txtSDT.Text;
                            tt.DiaChi = txtDiaChi.Text;
                            tt.TenDangNhap = txtTenDangNhap.Text;
                            tt.MatKhau = txtMatKhau.Text;

                            khachHangs.InsertOnSubmit(tt);
                            db.SubmitChanges();

                            MessageBox.Show("Đăng ký thành công");
                            this.Hide();
                            dangnhap.Show();
                        }
                        else
                            MessageBox.Show("Tên đăng nhập đã tồn tại!");
                    }
                    else
                        MessageBox.Show("Số điện thoại không hợp lệ!");
                }
                else
                    MessageBox.Show("Số điện thoại đã được đăng ký!");
            }
        }
    }
}
