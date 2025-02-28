using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyDuAn
{
    internal class NhanVien
    {
        public string MaNhanVien;
        public string HoTen;
        public string DiaChi;
        public double Luong;
        public string GioiTinh;
        public DateTime NgaySinh { get; set; }
        public PhongBan PhongBan;
        public NhanVien QuanLyTrucTiep;

        public NhanVien(string maNhanVien, string hoTen, string diaChi, double luong, string gioiTinh, DateTime ngaySinh, PhongBan phongBan, NhanVien quanLyTrucTiep = null)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            DiaChi = diaChi;
            Luong = luong;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            PhongBan = phongBan;
            QuanLyTrucTiep = quanLyTrucTiep;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ma NV: {MaNhanVien}, Ho Ten: {HoTen}, Phong: {PhongBan.TenPhong}, Quan ly truc tiep: {(QuanLyTrucTiep != null ? QuanLyTrucTiep.HoTen : "Khong co")}");
        }
    }
}
