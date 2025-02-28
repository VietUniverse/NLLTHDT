using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLyThuVien
{
    internal class MuonSach
    {
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public NguoiMuon NguoiMuon;

        public MuonSach(DateTime ngayMuon, DateTime ngayTra, NguoiMuon nguoiMuon)
        {
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
            NguoiMuon = nguoiMuon;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Ngay Muon: {NgayMuon.ToShortDateString()}, Ngay Tra: {NgayTra.ToShortDateString()}, Nguoi Muon: {NguoiMuon.HoTen}");
        }
    }
}
