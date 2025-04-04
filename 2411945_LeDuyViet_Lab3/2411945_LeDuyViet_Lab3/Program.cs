using System;
using System.Collections.Generic;

namespace _2411945_LeDuyViet_Lab3
{
    class Program
    {
        static void Main()
        {
            DanhSachSinhVien dsSinhVien = new DanhSachSinhVien();
            int choice;
            do
            {
                Console.WriteLine("\n==== MENU QUAN LY SINH VIEN ====");
                Console.WriteLine("1. Nhap danh sach sinh vien tu file");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Tim sinh vien co DTB cao nhat");
                Console.WriteLine("4. Tim lop co tong DTB cao nhat");
                Console.WriteLine("5. Tim lop co tong DTB thap nhat");
                Console.WriteLine("6. Tim lop co nhieu HSG nhat");
                Console.WriteLine("7. Tim lop co it HSG nhat");
                Console.WriteLine("8. Tim lop khong co nu");
                Console.WriteLine("9. Tim lop khong co nam");
                Console.WriteLine("10. Sap xep danh sach tang theo DTB");
                Console.WriteLine("11. Sap xep danh sach giam theo DTB");
                Console.WriteLine("12. Xuat danh sach sinh vien ra file");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon cua ban: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lua chon khong hop le! Vui long nhap lai.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        dsSinhVien.NhapTuFile();
                        Console.WriteLine("Da nhap danh sach sinh vien tu file.");
                        break;
                    case 2:
                        Console.WriteLine(dsSinhVien);
                        break;
                    case 3:
                        Console.WriteLine("Danh sach sinh vien co DTB cao nhat:");
                        Console.WriteLine(dsSinhVien.TimDSSVCoDTBCaoNhat());
                        break;
                    case 4:
                        Console.WriteLine("Lop co tong DTB cao nhat: " + dsSinhVien.TimLopCoTongDTBCaoNhat());
                        break;
                    case 5:
                        Console.WriteLine("Lop co tong DTB thap nhat: " + dsSinhVien.TimLopCoTongDTBThapNhat());
                        break;
                    case 6:
                        Console.WriteLine("Lop co nhieu HSG nhat: " + dsSinhVien.TimLopCoNhieuHSGNhat());
                        break;
                    case 7:
                        Console.WriteLine("Lop co it HSG nhat: " + dsSinhVien.TimLopCoItHSGNhat());
                        break;
                    case 8:
                        Console.WriteLine("Cac lop khong co nu: " + string.Join(", ", dsSinhVien.TimLopKhongCoNu()));
                        break;
                    case 9:
                        Console.WriteLine("Cac lop khong co nam: " + string.Join(", ", dsSinhVien.TimLopKhongCoNam()));
                        break;
                    case 10:
                        dsSinhVien.SapXepTangTheoDTB();
                        Console.WriteLine("Da sap xep danh sach tang theo DTB.");
                        break;
                    case 11:
                        dsSinhVien.SapXepGiamTheoDTB();
                        Console.WriteLine("Da sap xep danh sach giam theo DTB.");
                        break;
                    case 12:
                        dsSinhVien.XuatDanhSachSinhVien();
                        Console.WriteLine("Da xuat danh sach sinh vien ra file.");
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le! Vui long nhap lai.");
                        break;
                }
            } while (choice != 0);
        }
    }
}
