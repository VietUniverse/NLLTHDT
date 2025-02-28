using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLySieuThi
{
    internal class Bill
    {
        public string SoHoaDon;
        public DateTime NgayLapHoaDon;
        public string HoTenNhanVien;
        public string HoTenKhachHang;
        public string DiaChiKhachHang;
        public List<MatHang> DanhSachMatHang;
        public double TongTien;

        public Bill(string soHoaDon, DateTime ngayLap, string tenNV, string tenKH, string diaChi, List<MatHang> matHang)
        {
            SoHoaDon = soHoaDon;
            NgayLapHoaDon = ngayLap;
            HoTenNhanVien = tenNV;
            HoTenKhachHang = tenKH;
            DiaChiKhachHang = diaChi;
            DanhSachMatHang = matHang;
        }


    }
}
