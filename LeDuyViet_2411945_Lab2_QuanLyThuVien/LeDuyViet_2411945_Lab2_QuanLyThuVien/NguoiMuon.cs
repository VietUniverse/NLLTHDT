using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyThuVien
{
    internal class NguoiMuon
    {
        public string SoThe;
        public string HoTen;
        public string DiaChi;
        public string SoDienThoai;

        public NguoiMuon(string soThe, string hoTen, string diaChi, string soDienThoai)
        {
            SoThe = soThe;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"So The: {SoThe}, Ho Ten: {HoTen}, Dia Chi: {DiaChi}, SDT: {SoDienThoai}");
        }
    }
}
