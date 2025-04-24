using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap1
{
    internal class Nguoi
    {
        public string DiaChi { get; set; }
        public string Ten {  get; set; }
        public int Tuoi { get; set; }

        public Nguoi() { }

        public Nguoi(string diaChi, string ten, int tuoi)
        {
            DiaChi = diaChi;
            Ten = ten;
            Tuoi = tuoi;
        }

        public void HienThiThongTin() { }

        public override string ToString()
        {
            return string.Format("{0,10} {1,10} {2,5}", DiaChi, Ten, Tuoi);
        }
    }
}
