using System;
using System.Collections.Generic;
using System.Linq;
using LeDuyViet_2411945_Lab2_QuanLySieuThi;

class Program
{
    static void Main(string[] args)
    {
        List<Area> khuVuc = new List<Area>
        {
            new Area("KV01", "Thực phẩm", "Rau củ"),
            new Area("KV02", "Đồ uống", "Nước ngọt"),
            new Area("KV03", "Gia dụng", "Đồ nhà bếp"),
            new Area("KV04", "Quần áo", "Thời trang nam"),
            new Area("KV05", "Đồ điện tử", "Điện thoại")
        };

        List<MatHang> matHang = new List<MatHang>
        {
            new MatHang("MH01", "Táo", "Kg", 30000),
            new MatHang("MH02", "Coca Cola", "Lon", 10000),
            new MatHang("MH03", "Chảo chống dính", "Cái", 150000),
            new MatHang("MH04", "Áo thun", "Cái", 200000),
            new MatHang("MH05", "iPhone", "Chiếc", 20000000)
        };

        List<NhanVien> nhanVien = new List<NhanVien>
        {
            new NhanVien("NV01", "Nguyễn Văn A", new DateTime(1990, 1, 1), "Hà Nội", "0123456789", DateTime.Now, "123456789", "KV01"),
            new NhanVien("NV02", "Trần Thị B", new DateTime(1995, 2, 2), "Hà Nội", "0987654321", DateTime.Now, "987654321", "KV02"),
        };

        List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>
        {
            new NhaCungCap("NCC01", "Công ty A", "123456789", "Hà Nội", new List<string>{"0123456789"}, "a@company.com", new List<string>{"Táo", "Coca Cola"}),
        };

        List<Bill> hoaDon = new List<Bill>
        {
            new Bill("HD01", DateTime.Now, "Nguyễn Văn A", "Lê Thị C", "Hà Nội", new List<MatHang>{ matHang[0], matHang[1] }),
        };
    }
}
