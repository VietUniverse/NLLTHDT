using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyNCKH
{
    internal class GiangVien
    {
        public string HoTen;
        public List<string> SoDienThoai;
        public DiaChi DiaChi;
        public DateTime NgaySinh { get; set; }
        public double Luong;
        public string Phai;
        public BoMon BoMon;

        public GiangVien(string hoTen, List<string> soDienThoai, DiaChi diaChi, DateTime ngaySinh, double luong, string phai, BoMon boMon)
        {
            HoTen = hoTen;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
            NgaySinh = ngaySinh;
            Luong = luong;
            Phai = phai;
            BoMon = boMon;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Ngay sinh: {NgaySinh.ToShortDateString()}, Luong: {Luong}, Phai: {Phai}, Bo mon: {BoMon.TenBoMon}");
            Console.WriteLine("So dien thoai:");
            SoDienThoai.ForEach(sdt => Console.WriteLine($"- {sdt}"));
            DiaChi.HienThiThongTin();
        }
    }
}
