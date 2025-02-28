using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyDuAn
{
    internal class ThanNhan
    {
        public string HoTen;
        public string GioiTinh;
        public DateTime NgaySinh { get; set; }
        public string MoiQuanHe;

        public ThanNhan(string hoTen, string gioiTinh, DateTime ngaySinh, string moiQuanHe)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            MoiQuanHe = moiQuanHe;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Than nhan: {HoTen}, Gioi tinh: {GioiTinh}, Ngay sinh: {NgaySinh.ToShortDateString()}, Moi quan he: {MoiQuanHe}");
        }
    }
}
