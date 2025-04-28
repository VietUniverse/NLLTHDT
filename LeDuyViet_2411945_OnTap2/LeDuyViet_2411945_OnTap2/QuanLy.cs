using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap2
{
    internal class QuanLy : INguoi, INhanVien, IKhaNangQuanLy, IBaoCao, IQuanLyLuong
    {
        public string Ho { get; set; }
        public string Ten { get; set; }
        public int NhanVienID { get; set; }
        public string Phong { get; set; }
        public string NhiemVu { get; set; }
        public string TienDo { get; set; }
        public float Luong { get ; set; }

        public QuanLy() { }

        public QuanLy(string ho, string ten, int nhanVienID, string phong, float luong)
        {
            Ho = ho;
            Ten = ten;
            NhanVienID = nhanVienID;
            Phong = phong;
            Luong = luong;
        }

        public string LayTenDayDu()
        {
            return string.Format("{0,5} {1,5}", Ho, Ten);
        }

        public string LayThongTinChiTiet()
        {
            return string.Format("{0,5", NhanVienID) +  LayTenDayDu() + string.Format("{0,10} {1,10}", Phong, Luong);
        }

        public void GanNhiemVu(string nhiemVu)
        {
            NhiemVu = nhiemVu;
        }

        public void TaoBaoCao(string nv)
        {
            TienDo = nv;
        }

        public override string ToString()
        {
            return LayThongTinChiTiet();
        }

        public void TangLuong(double phanTram)
        {
            Luong += Luong * (float)phanTram;
        }
    }
}
