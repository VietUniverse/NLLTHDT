using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyThuVien
{
    internal class ChiNhanh
    {
        public string MaChiNhanh;
        public string TenChiNhanh;
        public string DiaChi;

        public ChiNhanh(string maChiNhanh, string tenChiNhanh, string diaChi)
        {
            MaChiNhanh = maChiNhanh;
            TenChiNhanh = tenChiNhanh;
            DiaChi = diaChi;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ma Chi Nhanh: {MaChiNhanh}, Tên Chi Nhanh: {TenChiNhanh}, Dia Chi: {DiaChi}");
        }
    }
}
