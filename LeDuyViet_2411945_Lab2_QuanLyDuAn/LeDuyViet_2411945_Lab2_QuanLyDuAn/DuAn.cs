using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyDuAn
{
    internal class DuAn
    {
        public string MaDuAn;
        public string TenDuAn;
        public string DiaDiemThucHien;
        public PhongBan PhongQuanLy;

        public DuAn(string maDuAn, string tenDuAn, string diaDiemThucHien, PhongBan phongQuanLy)
        {
            MaDuAn = maDuAn;
            TenDuAn = tenDuAn;
            DiaDiemThucHien = diaDiemThucHien;
            PhongQuanLy = phongQuanLy;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Du an: {TenDuAn}, Ma: {MaDuAn}, Dia diem: {DiaDiemThucHien}, Phong quan ly: {PhongQuanLy.TenPhong}");
        }
    }
}
