using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyNCKH
{
    internal class ChuDe
    {
        public string TenChuDe;

        public ChuDe(string tenChuDe)
        {
            TenChuDe = tenChuDe;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Chu de: {TenChuDe}");
        }

    }
}
