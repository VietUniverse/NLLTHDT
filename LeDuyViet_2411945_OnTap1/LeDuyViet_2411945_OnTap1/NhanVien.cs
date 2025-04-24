using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap1
{
    internal class NhanVien : Nguoi
    {
        public decimal Luong { get; set; }
        public string MaNV {  get; set; }
        public string ViTri { get; set; }

        public NhanVien() { }
        public NhanVien(string diaChi, string ten, int tuoi, decimal luong, string maNV, string viTri) : base(diaChi, ten, tuoi)
        {
            Luong = luong;
            MaNV = maNV;
            ViTri = viTri;
        }

        public void HienThiThongTin()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " " + string.Format("{0,5} {1,5} {2,10}", Luong, MaNV, ViTri);
        }
    }
}
