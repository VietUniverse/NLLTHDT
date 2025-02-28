using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyNCKH
{
    internal class BoMon
    {
        public string TenBoMon;
        public string PhongLamViec;
        public string DienThoai;
        public GiangVien TruongBoMon;
        public DateTime NgayNhanChuc;

        public BoMon(string tenBoMon, string phongLamViec, string dienThoai, GiangVien truongBoMon, DateTime ngayNhanChuc)
        {
            TenBoMon = tenBoMon;
            PhongLamViec = phongLamViec;
            DienThoai = dienThoai;
            TruongBoMon = truongBoMon;
            NgayNhanChuc = ngayNhanChuc;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Bo mon: {TenBoMon}, Phong: {PhongLamViec}, Dien thoai: {DienThoai}, Truong bo mon: {TruongBoMon.HoTen}, Ngay nhan chuc: {NgayNhanChuc.ToShortDateString()}");
        }
    }
}
