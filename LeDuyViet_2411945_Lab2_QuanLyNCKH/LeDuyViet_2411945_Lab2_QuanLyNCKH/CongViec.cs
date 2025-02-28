using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyNCKH
{
    internal class CongViec
    {
        public string TenCongViec;
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public List<GiangVien> GiangVienThamGia;

        public CongViec(string tenCongViec, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            TenCongViec = tenCongViec;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            GiangVienThamGia = new List<GiangVien>();
        }

        public void ThemGiangVien(GiangVien gv)
        {
            GiangVienThamGia.Add(gv);
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Cong viec: {TenCongViec}, Bat dau: {NgayBatDau.ToShortDateString()}, Ket thuc: {NgayKetThuc.ToShortDateString()}");
            Console.WriteLine("Giang vien tham gia:");
            GiangVienThamGia.ForEach(gv => Console.WriteLine($"- {gv.HoTen}"));
        }
    }
}
