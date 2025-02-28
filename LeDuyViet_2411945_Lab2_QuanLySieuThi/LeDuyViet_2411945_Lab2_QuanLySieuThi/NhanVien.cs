using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLySieuThi
{
    public class NhanVien
    {
        public string MaSo;
        public string HoTen;
        public DateTime NgaySinh { get; set; }
        public string DiaChi;
        public string DienThoai;
        public DateTime NgayVaoLam;
        public string CMND;
        public string KhuVucLamViec;

        public NhanVien(string maSo, string hoTen, DateTime ngaySinh, string diaChi,
                        string dienThoai, DateTime ngayVaoLam, string cmnd, string khuVucLamViec)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            NgayVaoLam = ngayVaoLam;
            CMND = cmnd;
            KhuVucLamViec = khuVucLamViec;
        }
    }

}
