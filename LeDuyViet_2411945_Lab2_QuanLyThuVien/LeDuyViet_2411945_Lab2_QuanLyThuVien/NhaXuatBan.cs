using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyThuVien
{
    internal class NhaXuatBan
    {
        public string TenNhaXuatBan;
        public string DiaChi;
        public string SoDienThoai;
        public NhaXuatBan(string tenNhaXuatBan, string diaChi, string soDienThoai)
        {
            TenNhaXuatBan = tenNhaXuatBan;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Nha Xuat Ban: {TenNhaXuatBan}, Dia Chi: {DiaChi}, SDT: {SoDienThoai}");
        }
    }
}
