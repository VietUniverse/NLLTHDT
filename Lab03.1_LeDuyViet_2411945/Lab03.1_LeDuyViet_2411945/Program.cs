using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab03._1_LeDuyViet_2411945
{
    internal class Program
    {
        public enum Menu
        {
            Nhap = 0,
            NhapTuFile,
            Them,
            Xuat,
            TimDSCacThanhPho,
            DemSoThueBaoTheoTP,
            TimTPCoNhieuThueBaoNhat,
            TimTPCoItThueBaoNhat,
            TimThueBaoItSoDTNhat,
            SapXepTangTheoTen,
            SapXepGiamTheoTen,
            Thoat
        }
        static void Main(string[] agrs)
        {
            DanhBa db = new DanhBa();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chon chuc nang ");
                Console.WriteLine($"Nhap {(int)Menu.NhapTuFile} de nhap tu file ");
                Console.WriteLine($"Nhap {(int)Menu.Them} de nhap tu ban phim");
                Console.WriteLine($"Nhap {(int)Menu.Xuat} de xuat danh ba");
                Console.WriteLine($"Nhap {(int)Menu.TimDSCacThanhPho} de tim danh sach cac thanh pho");
                Console.WriteLine($"Nhap {(int)Menu.DemSoThueBaoTheoTP} de dem so thue bao theo thanh pho");
                Console.WriteLine($"Nhap {(int)Menu.TimTPCoNhieuThueBaoNhat} de tim thanh pho co nhieu thue bao nhat");
                Console.WriteLine($"Nhap {(int)Menu.TimTPCoItThueBaoNhat} de tim thanh pho co it thue bao nhat");
                Console.WriteLine($"Nhap {(int)Menu.SapXepTangTheoTen} de sap xep tang dan theo ten");
                Console.WriteLine($"Nhap {(int)Menu.SapXepGiamTheoTen} de sap xep giam dan theo ten");
                Console.WriteLine($"Nhap {(int)Menu.Thoat} de thoat");
                Menu chon = (Menu)int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case Menu.NhapTuFile:
                        db.NhapTuFile();
                        break;
                    case Menu.Them:
                        Console.WriteLine("Nhap cac mien cach nhau boi dau ','");
                        db.Them(new ThueBao(Console.ReadLine())); 
                        break;
                    case Menu.Xuat:
                        db.Xuat();
                        break;
                    case Menu.TimDSCacThanhPho:
                        List<string> kq = db.TimDSCacThanhPho();
                        foreach (var item in kq)
                        {
                            Console.WriteLine($"Thanh pho {item}");
                        }
                        break;
                    case Menu.DemSoThueBaoTheoTP:
                        List<string> kq1 = db.TimDSCacThanhPho();
                        foreach (var item in kq1)
                        {
                            Console.WriteLine(item + " so thue bao " + db.DemSoThueBaoTheoTP(item));
                        }
                        break;
                    case Menu.TimTPCoNhieuThueBaoNhat:
                        List<string> kq2 = db.TimTPCoNhieuThueBaoNhat();
                        foreach (var item in kq2)
                        {
                            Console.WriteLine(item + " so thue bao lon nhat " + db.DemSoThueBaoTheoTP(item));
                        }
                        break;
                    case Menu.TimTPCoItThueBaoNhat:
                        List<string> kq3 = db.TimTPCoItThueBaoNhat();
                        foreach (var item in kq3)
                        {
                            Console.WriteLine(item + " so thue bao it nhat " + db.DemSoThueBaoTheoTP(item));
                        }
                        break;
                    case Menu.TimThueBaoItSoDTNhat:
                        List<string> kq4 = db.TimThueBaoItSoDTNhat();
                        foreach (var item in kq4)
                        {
                            Console.WriteLine(item + " so thue bao it nhat " + db.DemSoCuaThueBao(item));
                        }
                        break;
                    case Menu.SapXepTangTheoTen:
                        db.SapXepTangTheoTen();
                        db.Xuat();
                        break;
                    case Menu.SapXepGiamTheoTen:
                        db.SapXepGiamTheoTen();
                        db.Xuat();
                        break;
                    default:
                        return;
                }
                Console.WriteLine("Bam 1 phim de tiep tuc ");
                Console.ReadKey();
            }
        }
    }
}