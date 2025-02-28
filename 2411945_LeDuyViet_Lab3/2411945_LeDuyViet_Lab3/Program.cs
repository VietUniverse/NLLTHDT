using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2411945_LeDuyViet_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachSinhVien ds = new DanhSachSinhVien();
            ds.NhapTuFile();
            Console.WriteLine(ds);
            Console.ReadKey();
        }
    }
}