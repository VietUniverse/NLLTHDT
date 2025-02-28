using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyThuVien
{
    internal class BanSaoSach
    {
        public string MaSach;
        public int SoLuongBanSao;

        public BanSaoSach(string maSach, int soLuongBanSao)
        {
            MaSach = maSach;
            SoLuongBanSao = soLuongBanSao;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ma Sach: {MaSach}, So Luong Ban Sao: {SoLuongBanSao}");
        }
    }
}
