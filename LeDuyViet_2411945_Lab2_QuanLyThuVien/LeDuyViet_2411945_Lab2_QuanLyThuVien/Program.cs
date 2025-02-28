using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeDuyViet_2411945_Lab2_QuanLyThuVien;

class Program
{
    static void Main()
    {
        var chiNhanh = new List<ChiNhanh>
        {
            new ChiNhanh("CN01", "Chi Nhanh 1", "Ha Noi"),
            new ChiNhanh("CN02", "Chi Nhanh 2", "Ho Chi Minh"),
            new ChiNhanh("CN03", "Chi Nhanh 3", "Da Nang"),
            new ChiNhanh("CN04", "Chi Nhanh 4", "Hue"),
            new ChiNhanh("CN05", "Chi Nhanh 5", "Can Tho")
        };

        var nxb = new NhaXuatBan("NXB Kim Dong", "Ha Noi", "0123456789");
        var nxb2 = new NhaXuatBan("NXB Tre", "HCM", "0987654321");

        var sach = new List<Sach>
        {
            new Sach("S01", "De Men Phieu Luu Ky", "To Hoai", nxb),
            new Sach("S02", "Tuoi Tho Du Doi", "Phung Quan", nxb2)
        };

        var banSaoSach = new List<BanSaoSach>
        {
            new BanSaoSach("S01", 5),
            new BanSaoSach("S02", 3)
        };

        var nguoiMuon = new List<NguoiMuon>
        {
            new NguoiMuon("T01", "Nguyen Van A", "Ha Noi", "0123456789"),
            new NguoiMuon("T02", "Tran Thi B", "HCM", "0987654321")
        };

        var muonSach = new List<MuonSach>
        {
            new MuonSach(DateTime.Now.AddDays(-5), DateTime.Now, nguoiMuon[0]),
            new MuonSach(DateTime.Now.AddDays(-3), DateTime.Now, nguoiMuon[1])
        };

        chiNhanh.ForEach(cn => cn.HienThiThongTin());
        sach.ForEach(s => s.HienThiThongTin());
        muonSach.ForEach(ms => ms.HienThiThongTin());
    }
}
