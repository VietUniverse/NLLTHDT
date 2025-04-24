using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap1
{
    internal class QuanLy : NhanVien 
    {
        public string Phong { get; set; }

        public QuanLy() { }
        public QuanLy(string diaChi, string ten, int tuoi, decimal luong, string maNV, string viTri, string phong) : base(diaChi, ten, tuoi, luong, maNV, viTri)
        { 
            Phong = phong;
        }
        public void HienThiThongTin()
        {}

        public override string ToString()
        {
            return base.ToString() + " " + Phong;
        }

    }
}
