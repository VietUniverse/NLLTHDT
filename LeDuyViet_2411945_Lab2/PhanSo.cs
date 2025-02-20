using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2
{
    internal class PhanSo
    {
        public int tu;
        public int mau;
        public void Nhap()
        {
            Console.Write("Nhap tu ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau ");
            mau = int.Parse(Console.ReadLine());
        } 
        public void Xuat()
        {
            Console.WriteLine($" {tu} / {mau}");
        }

        public PhanSo()
        {}

        public PhanSo(int t, int m)
        {
            tu = t;
            mau = m;
        }
        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau + b.tu * a.mau;
            kq.mau = a.mau * b.mau;
            return RutGonPhanSo(kq);
        }

        static int UocChungLonNhat(int a, int b)
        {
            if (b == 0) return Math.Abs(a);
            return UocChungLonNhat(b, a % b);
        }


        public PhanSo RutGonPhanSo(PhanSo data)
        {
            PhanSo res = new PhanSo();
            int Ucln = UocChungLonNhat(data.tu, data.mau);
            res.tu = data.tu / Ucln;
            res.mau = data.mau / Ucln;
            return res;
        }

        public PhanSo Tru(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo(a.tu * b.mau - b.tu * a.mau, a.mau * b.mau);
            return RutGonPhanSo(res);
        }
        
        public PhanSo Nhan(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo(a.tu * b.tu, a.mau * b.mau);
            return RutGonPhanSo(res);
        }

        public PhanSo Chia(PhanSo a, PhanSo b)
        {
            PhanSo res = new PhanSo(a.tu * b.mau, b.tu * a.mau);
            return RutGonPhanSo(res);
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tu * b.mau + b.tu * a.mau, a.mau * b.mau);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tu * b.mau - b.tu * a.mau, a.mau * b.mau);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tu * b.tu, a.mau * b.mau);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.tu == 0)
                throw new DivideByZeroException("Không thể chia cho phân số có tử số bằng 0");
            return new PhanSo(a.tu * b.mau, a.mau * b.tu);
        }



    }
}
