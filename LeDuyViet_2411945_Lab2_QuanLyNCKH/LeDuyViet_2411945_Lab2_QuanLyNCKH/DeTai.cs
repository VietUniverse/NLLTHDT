using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyNCKH
{
    internal class DeTai
    {
        public string TenDeTai;
        public string CapQuanLy;
        public double KinhPhi;
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public ChuDe ChuDe;
        public List<CongViec> CongViecList;

        public DeTai(string tenDeTai, string capQuanLy, double kinhPhi, DateTime ngayBatDau, DateTime ngayKetThuc, ChuDe chuDe)
        {
            TenDeTai = tenDeTai;
            CapQuanLy = capQuanLy;
            KinhPhi = kinhPhi;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
            ChuDe = chuDe;
            CongViecList = new List<CongViec>();
        }

        public void ThemCongViec(CongViec congViec)
        {
            CongViecList.Add(congViec);
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"De tai: {TenDeTai}, Cap quan ly: {CapQuanLy}, Kinh phi: {KinhPhi}, Chu de: {ChuDe.TenChuDe}");
            Console.WriteLine("Cong viec:");
            CongViecList.ForEach(cv => cv.HienThiThongTin());
        }
    }
}
