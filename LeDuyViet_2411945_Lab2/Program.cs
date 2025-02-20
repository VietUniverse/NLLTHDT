using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2
{
    internal class Program()
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo(1,2);
            a.Xuat();

            PhanSo b = new PhanSo(3, 4);
            b.Xuat();

            PhanSo cong = a + b;
            cong.Xuat();
            
            PhanSo tru = a - b;
            tru.Xuat();

            PhanSo nhan = a * b;
            nhan.Xuat();

            PhanSo chia = a * b;
            chia.Xuat();
        }
    }
}