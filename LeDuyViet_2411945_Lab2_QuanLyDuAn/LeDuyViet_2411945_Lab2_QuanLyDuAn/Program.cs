using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeDuyViet_2411945_Lab2_QuanLyDuAn;

class Program
{
    static void Main()
    {
        var phongIT = new PhongBan("PB01", "Phong IT", null, DateTime.Now, new List<string> { "Ha Noi", "HCM" });
        var phongHR = new PhongBan("PB02", "Phong HR", null, DateTime.Now, new List<string> { "Da Nang" });

        var truongPhongIT = new NhanVien("NV01", "Nguyen Van A", "Ha Noi", 1500, "Nam", new DateTime(1985, 1, 1), phongIT);
        phongIT.TruongPhong = truongPhongIT;

        var truongPhongHR = new NhanVien("NV02", "Tran Thi B", "Da Nang", 1600, "Nu", new DateTime(1980, 2, 2), phongHR);
        phongHR.TruongPhong = truongPhongHR;

        var duAn1 = new DuAn("DA01", "He thong ERP", "Ha Noi", phongIT);
        var duAn2 = new DuAn("DA02", "Website Tuyen Dung", "Da Nang", phongHR);

        var thanNhan1 = new ThanNhan("Nguyen Van C", "Nam", new DateTime(2010, 3, 3), "Con");
        var thanNhan2 = new ThanNhan("Nguyen Thi D", "Nu", new DateTime(2015, 4, 4), "Con");

        phongIT.HienThiThongTin();
        phongHR.HienThiThongTin();

        truongPhongIT.HienThiThongTin();
        truongPhongHR.HienThiThongTin();

        duAn1.HienThiThongTin();
        duAn2.HienThiThongTin();

        thanNhan1.HienThiThongTin();
        thanNhan2.HienThiThongTin();
    }
}
