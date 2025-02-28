using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyDuAn
{
    internal class PhongBan
    {
        public string MaPhong;
        public string TenPhong;
        public NhanVien TruongPhong;
        public DateTime NgayNhanChuc;
        public List<string> DiaDiemVanPhong;

        public PhongBan(string maPhong, string tenPhong, NhanVien truongPhong, DateTime ngayNhanChuc, List<string> diaDiemVanPhong)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            TruongPhong = truongPhong;
            NgayNhanChuc = ngayNhanChuc;
            DiaDiemVanPhong = diaDiemVanPhong;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Phong: {TenPhong}, Ma: {MaPhong}, Truong phong: {TruongPhong.HoTen}, Ngay nhan chuc: {NgayNhanChuc.ToShortDateString()}");
            Console.WriteLine("Dia diem van phong:");
            DiaDiemVanPhong.ForEach(diaDiem => Console.WriteLine($"- {diaDiem}"));
        }
    }
}
