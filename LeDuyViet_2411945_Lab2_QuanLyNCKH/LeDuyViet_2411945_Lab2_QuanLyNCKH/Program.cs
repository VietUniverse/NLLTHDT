using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeDuyViet_2411945_Lab2_QuanLyNCKH;

class Program
{
    static void Main()
    {
        var diaChi1 = new DiaChi("123", "Le Loi", "Quan 1", "HCM");
        var diaChi2 = new DiaChi("456", "Tran Phu", "Quan 3", "HCM");

        var boMonCNTT = new BoMon("Cong Nghe Thong Tin", "A101", "0281234567", null, DateTime.Now);

        var giangVien1 = new GiangVien("Nguyen Van A", new List<string> { "0912345678" }, diaChi1, new DateTime(1980, 1, 1), 1500, "Nam", boMonCNTT);
        var giangVien2 = new GiangVien("Tran Thi B", new List<string> { "0987654321" }, diaChi2, new DateTime(1985, 2, 2), 1600, "Nu", boMonCNTT);

        boMonCNTT.TruongBoMon = giangVien1;

        var chuDeAI = new ChuDe("Tri Tue Nhan Tao");
        var deTaiAI = new DeTai("Nghien cuu AI", "Cap truong", 50000, DateTime.Now, DateTime.Now.AddMonths(6), chuDeAI);

        var congViec1 = new CongViec("Phan tich du lieu", DateTime.Now, DateTime.Now.AddMonths(2));
        congViec1.ThemGiangVien(giangVien1);

        deTaiAI.ThemCongViec(congViec1);

        deTaiAI.HienThiThongTin();
    }
}
