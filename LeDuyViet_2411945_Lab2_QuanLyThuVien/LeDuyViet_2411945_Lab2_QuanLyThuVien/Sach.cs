using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyThuVien
{
    internal class Sach
    {
        public string MaSach;
        public string TenSach;
        public string TacGia;
        public NhaXuatBan NhaXuatBan;

        public Sach(string maSach, string tenSach, string tacGia, NhaXuatBan nhaXuatBan)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
            NhaXuatBan = nhaXuatBan;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ma Sách: {MaSach}, Ten Sach: {TenSach}, Tac Gia: {TacGia}, Nha Xuat Ban: {NhaXuatBan.TenNhaXuatBan}");
        }
    }
}
