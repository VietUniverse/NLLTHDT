using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace Lab07_KeThuaVaDaKeThua_QuanLyDV_
{
    internal class Program
    {
        public enum Menu
        {
            NhapTuFile = 1,
            XuatDS,
            Them1DVVaoDS,
            DemSLDVLaBat_Lion_Bird,
            DemSLDVBietBay_KoBietBay,
            DemSLDVBietBay_KoBietBayTheoTen,
            DemSLDVBietBay_KoBietBayTheoTuoi,
            TimDVCoSLNhieuNhat_ItNhat,
            TimDVThuocLoaiBat,
            TimDVThuocLoaiLion,
            TimDVThuocLoaiBird,
            TimDVTenNganNhat_DaiNhat,
            TimDVTuoiLonNhat_NhoNhat,
            TimDVTenNganNhat_DaiNhatTheoLoai,
            TimDVTuoiLonNhat_NhoNhatTheoLoai,
            TimDSDVBietBay,
            TimDSDVKoBietBay,
            SapXepTang_GiamTheoTen,
            SapXepTang_GiamTheoTuoi,
            XoaDVTheoLoai,
            XoaDVBietBay,
            XoaDVKoBietBay,
            XoaDVBietBayTheoTen,
            XoaDVBietBayTheoTuoi,
            XoaDVKoBietBayTheoTen,
            XoaDVKoBietBayTheoTuoi,
            XoaDVTuoiNhoNhat,
            XoaDVTuoiLonNhat,
            XoaDVTuoiNhoNhatTheoLoai,
            XoaDVTuoiLonNhatTheoLoai,
            XoaDVTrongDS,
            XoaDVTaiViTriX,
            TinhTuoiDVTheoLoai,
            TinhTongTuoiDVBietBay,
            TinhTongTuoiDVKoBietBay,
            ThemDVVaoViTriX,
            HienThiDanhSachDVTangDanTheoTen,
            HienThiDanhSachDVGiamDanTheoTen,
            HienThiDanhSachDVTangDanTheoTuoi,
            HienThiDanhSachDVGiamDanTheoTuoi,
            Thoat
        }
        static void Main(string[] args)
        {
            //QuanLyDV ds = new QuanLyDV();
            //ds.NhapTuFile("DSDongVat.txt");

            //ds.ThemDV();
            //ds.Xuat();

            //ds.XuatDSSLDV();

            //Console.Write("Nhap loai (Bat, Lion, Bird): ");
            //string x = Console.ReadLine();
            //ds.DemSLDVLaBat_Lion_Bird(x);

            //ds.DemSLDVBietBay_KhongBietBay();

            //ds.TimDVCoSLMax_Min();

            //List<string> kq1 = ds.TimDVThuocLoaiBat();
            //ds.XuatList(kq1);
            //List<string> kq2 = ds.TimDVThuocLoaiBird();
            //ds.XuatList(kq2);
            //List<string> kq3 = ds.TimDVThuocLoaiLion();
            //ds.XuatList(kq3);

            //ds.TuoiLonNhat_NhoNhat();

            //Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
            //string x = Console.ReadLine();
            //List<string> kq1 = ds.TuoiLonNhatTheoLoai(x);
            //List<string> kq2 = ds.TuoiNhoNhatTheoLoai(x);
            //ds.XuatList(kq1);
            //ds.XuatList(kq2);

            //ds.SapTangTheoTen();
            //ds.Xuat();
            //ds.SapGiamTheoTen();
            //ds.Xuat();

            //ds.SapTangTheoTuoi();
            //ds.Xuat();
            //ds.SapGiamTheoTuoi();
            //ds.Xuat();

            //Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
            //string x = Console.ReadLine();
            //ds.XoaDVTheoLoai(x);
            //Console.WriteLine($"ds da xoa loai {x}: ");
            //ds.Xuat();

            //ds.XoaDVBietBay();
            //ds.Xuat();
            //ds.XoaDVKhongBietBay();
            //ds.Xuat();

            //ds.Xuat();
            //Console.Write("Nhap ten dv biet bay can xoa: ");
            //string x = Console.ReadLine();
            //Console.Write("Nhap ten dv khong biet bay can xoa: ");
            //string y = Console.ReadLine();
            //Console.Write("Nhap tuoi dv biet bay can xoa: ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("Nhap tuoi dv khong biet bay can xoa: ");
            //int n = int.Parse(Console.ReadLine());
            //ds.XoaDVBietBayTheoTen(x);
            //ds.XoaDVKhongBietBayTheoTen(y);
            //ds.XoaDVBietBayTheoTuoi(m);
            //ds.XoaDVKhongBietBayTheoTuoi(n);
            //Console.Clear();
            //ds.Xuat();

            //Console.WriteLine("DS truoc khi xoa: ");
            //ds.Xuat();
            //Console.WriteLine("DS sau khi xoa dv tuoi max - min: ");
            //ds.XoaDVTuoiMax();
            //ds.XoaDVTuoiMin();
            //ds.Xuat();

            //Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
            //string x = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine($"DS truoc khi xoa dv co tuoi max - min theo loai: {x}");
            //ds.Xuat();
            //Console.WriteLine($"DS sau khi xoa dv co tuoi max - min theo loai: {x}");
            //ds.XoaDVTuoiMaxTheoLoai(x);
            //ds.XoaDVTuoiMinTheoLoai(x);
            //ds.Xuat();

            //ds.Xuat();
            //Console.Write("Nhap ten dv can xoa: ");
            //string x = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine($"DS truoc khi xoa dv {x}:");
            //ds.Xuat();
            //Console.WriteLine($"DS sau khi xoa dv {x}: ");
            //ds.XoaDVTrongDS(x);
            //ds.Xuat();

            //ds.Xuat();
            //Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
            //string x = Console.ReadLine();
            //Console.WriteLine(ds.TinhTongTuoiTheoLoai(x));

            //Console.WriteLine(ds.TinhTongTuoiDVBietBay());
            //Console.WriteLine(ds.TinhTongTuoiDVKhongBietBay());

            //ds.Xuat();
            //Console.Write("DS ten dai nhat la: ");
            //ds.XuatList(ds.DSTenDaiNhat());

            //Console.Write("DS ten ngan nhat la: ");
            //ds.XuatList(ds.DSTenNganNhat());

            //ds.Xuat();
            //Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
            //string x = Console.ReadLine();
            //Console.Write($"DS dv co ten dai nhat theo loai {x} la: ");
            //ds.XuatList(ds.TenDaiNhatTheoLoai(x));
            //Console.Write($"DS dv co ten ngan nhat theo loai {x} la: ");
            //ds.XuatList(ds.TenNganNhatTheoLoai(x));

            QuanLyDV ds = new QuanLyDV();
            string x;
            int y;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Nhap {(int)Menu.NhapTuFile} de nhap thong tin tu file");
                Console.WriteLine($"Nhap {(int)Menu.XuatDS} de xuat ds");
                Console.WriteLine($"Nhap {(int)Menu.Them1DVVaoDS} de them 1 IAnimal vao ds");
                Console.WriteLine($"Nhap {(int)Menu.DemSLDVLaBat_Lion_Bird} de dem sl dv la Bat, Lion, Bird");
                Console.WriteLine($"Nhap {(int)Menu.DemSLDVBietBay_KoBietBay} de dem sl dv biet bay va khong biet bay");
                Console.WriteLine($"Nhap {(int)Menu.DemSLDVBietBay_KoBietBayTheoTen} de dem sl dv biet bay, khong biet bay theo ten");
                Console.WriteLine($"Nhap {(int)Menu.DemSLDVBietBay_KoBietBayTheoTuoi} de dem sl dv biet bay, khong biet bay theo tuoi");
                Console.WriteLine($"Nhap {(int)Menu.TimDVCoSLNhieuNhat_ItNhat} de tim dv co sl nhieu nhat, it nhat");
                Console.WriteLine($"Nhap {(int)Menu.TimDVThuocLoaiBat} de tim dv thuoc loai Bat");
                Console.WriteLine($"Nhap {(int)Menu.TimDVThuocLoaiLion} de tim dv thuoc loai Lion");
                Console.WriteLine($"Nhap {(int)Menu.TimDVThuocLoaiBird} de tim dv thuoc loai Bird");
                Console.WriteLine($"Nhap {(int)Menu.TimDVTenNganNhat_DaiNhat} de tim dv co ten ngan nhat, dai nhat");
                Console.WriteLine($"Nhap {(int)Menu.TimDVTuoiLonNhat_NhoNhat} de tim dv co tuoi lon nhat, nho nhat");
                Console.WriteLine($"Nhap {(int)Menu.TimDVTenNganNhat_DaiNhatTheoLoai} de tim dv co ten ngan nhat, dai nhat theo loai");
                Console.WriteLine($"Nhap {(int)Menu.TimDVTuoiLonNhat_NhoNhatTheoLoai} de tim dv co tuoi lon nhat, nho nhat theo loai");
                Console.WriteLine($"Nhap {(int)Menu.TimDSDVBietBay} de tim ds dv biet bay");
                Console.WriteLine($"Nhap {(int)Menu.TimDSDVKoBietBay} de tim ds dv khong biet bay");
                Console.WriteLine($"Nhap {(int)Menu.SapXepTang_GiamTheoTen} de sap xep ds tang_giam theo ten");
                Console.WriteLine($"Nhap {(int)Menu.SapXepTang_GiamTheoTuoi} de sap xep ds tang_giam theo tuoi");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVTheoLoai} de xoa dv theo loai");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVBietBay} de xoa dv biet bay");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVKoBietBay} de xoa dv khong biet bay");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVBietBayTheoTen} de xoa dv biet bay theo ten");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVBietBayTheoTuoi} de xoa dv biet bay theo tuoi");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVKoBietBayTheoTen} de xoa dv khong biet bay theo ten");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVKoBietBayTheoTuoi} de xoa dv khong biet bay theo tuoi");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVTuoiNhoNhat} de xoa dv nho tuoi nhat");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVTuoiLonNhat} de xoa dv lon tuoi nhat");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVTuoiLonNhatTheoLoai} de xoa dv lon tuoi nhat theo loai");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVTuoiNhoNhatTheoLoai} de xoa dv nho tuoi nhat theo loai");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVTrongDS} de xoa dv trong ds");
                Console.WriteLine($"Nhap {(int)Menu.XoaDVTaiViTriX} de xoa dv tai vi tri x");
                Console.WriteLine($"Nhap {(int)Menu.TinhTuoiDVTheoLoai} de tinh tong tuoi dv theo loai");
                Console.WriteLine($"Nhap {(int)Menu.TinhTongTuoiDVBietBay} de tinh tong tuoi dv biet bay");
                Console.WriteLine($"Nhap {(int)Menu.TinhTongTuoiDVKoBietBay} de tinh tong tuoi dv khong biet bay");
                Console.WriteLine($"Nhap {(int)Menu.ThemDVVaoViTriX} de them dv vao vi tri x");
                Console.WriteLine($"Nhap {(int)Menu.HienThiDanhSachDVTangDanTheoTen} de xuat danh sach dong vat tang dan theo ten");
                Console.WriteLine($"Nhap {(int)Menu.HienThiDanhSachDVGiamDanTheoTen} de xuat danh sach dong vat giam dan theo ten");
                Console.WriteLine($"Nhap {(int)Menu.HienThiDanhSachDVTangDanTheoTuoi} de xuat danh sach dong vat tang dan theo tuoi");
                Console.WriteLine($"Nhap {(int)Menu.HienThiDanhSachDVGiamDanTheoTuoi} de xuat danh sach dong vat giam dan theo tuoi");
                Console.WriteLine($"Nhap {(int)Menu.Thoat} de thoat");
                Console.WriteLine();
                Console.Write("Nhap chuc nang: ");
                Menu chon = (Menu)int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case Menu.NhapTuFile:
                        ds.NhapTuFile("DSDongVat.txt");
                        break;

                    case Menu.XuatDS:
                        ds.Xuat();
                        break;

                    case Menu.Them1DVVaoDS:
                        ds.ThemDV(ds.Counting());
                        break;

                    case Menu.DemSLDVLaBat_Lion_Bird:
                        Console.Write("Nhap loai (Bat, Lion, Bird): ");
                        x = Console.ReadLine();
                        ds.DemSLDVLaBat_Lion_Bird(x);
                        break;

                    case Menu.DemSLDVBietBay_KoBietBay:
                        ds.DemSLDVBietBay_KhongBietBay();
                        break;

                    case Menu.DemSLDVBietBay_KoBietBayTheoTen:
                        break;

                    case Menu.DemSLDVBietBay_KoBietBayTheoTuoi:
                        break;

                    case Menu.TimDVCoSLNhieuNhat_ItNhat:
                        ds.TimDVCoSLMax_Min();
                        break;

                    case Menu.TimDVThuocLoaiBat:
                        List<string> kq1 = ds.TimDVThuocLoaiBat();
                        ds.XuatList(kq1);
                        break;

                    case Menu.TimDVThuocLoaiLion:
                        List<string> kq2 = ds.TimDVThuocLoaiLion();
                        ds.XuatList(kq2);
                        break;

                    case Menu.TimDVThuocLoaiBird:
                        List<string> kq3 = ds.TimDVThuocLoaiLion();
                        ds.XuatList(kq3);
                        break;

                    case Menu.TimDVTenNganNhat_DaiNhat:
                        ds.Xuat();
                        Console.Write("DS ten dai nhat la: ");
                        ds.XuatList(ds.DSTenDaiNhat());
                        Console.Write("DS ten ngan nhat la: ");
                        ds.XuatList(ds.DSTenNganNhat());
                        break;

                    case Menu.TimDVTuoiLonNhat_NhoNhat:
                        ds.TuoiLonNhat_NhoNhat();
                        break;

                    case Menu.TimDVTenNganNhat_DaiNhatTheoLoai:
                        ds.Xuat();
                        Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
                        x = Console.ReadLine();
                        Console.Write($"DS dv co ten dai nhat theo loai {x} la: ");
                        ds.XuatList(ds.TenDaiNhatTheoLoai(x));
                        Console.Write($"DS dv co ten ngan nhat theo loai {x} la: ");
                        ds.XuatList(ds.TenNganNhatTheoLoai(x));
                        break;

                    case Menu.TimDVTuoiLonNhat_NhoNhatTheoLoai:
                        Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
                        x = Console.ReadLine();
                        List<string> dstuoimax = ds.TuoiLonNhatTheoLoai(x);
                        List<string> dstuoimin = ds.TuoiNhoNhatTheoLoai(x);
                        Console.Write($"DS dv thuoc loai {x} lon tuoi nhat la: ");
                        ds.XuatList(dstuoimax);
                        Console.WriteLine();
                        Console.Write($"DS dv thuoc loai {x} nho tuoi nhat la: ");
                        ds.XuatList(dstuoimin);
                        break;

                    case Menu.TimDSDVBietBay:
                        Console.Write("ds dv biet bay: ");
                        ds.DSDVBietBay();
                        break;

                    case Menu.TimDSDVKoBietBay:
                        Console.Write("ds dv khong biet bay: ");
                        ds.DSDVKhongBietBay();
                        break;

                    case Menu.SapXepTang_GiamTheoTen:
                        Console.Write("Chon tang hoac giam (T/G): ");
                        x = Console.ReadLine();
                        if (x == "T" || x == "t")
                        {
                            Console.WriteLine("DS truoc khi sap xep: ");
                            ds.Xuat();
                            Console.WriteLine("DS sau khi sap xep: ");
                            ds.SapTangTheoTen();
                            ds.Xuat();
                        }
                        else if (x == "G" || x == "g")
                        {
                            Console.WriteLine("DS truoc khi sap xep: ");
                            ds.Xuat();
                            Console.WriteLine("DS sau khi sap xep: ");
                            ds.SapGiamTheoTen();
                            ds.Xuat();
                        }
                        break;

                    case Menu.SapXepTang_GiamTheoTuoi:
                        Console.Write("Chon tang hoac giam (T/G): ");
                        x = Console.ReadLine();
                        if (x == "T" || x == "t")
                        {
                            Console.WriteLine("DS truoc khi sap xep: ");
                            ds.Xuat();
                            Console.WriteLine("DS sau khi sap xep: ");
                            ds.SapTangTheoTuoi();
                            ds.Xuat();
                        }
                        else if (x == "G" || x == "g")
                        {
                            Console.WriteLine("DS truoc khi sap xep: ");
                            ds.Xuat();
                            Console.WriteLine("DS sau khi sap xep: ");
                            ds.SapGiamTheoTuoi();
                            ds.Xuat();
                        }
                        break;

                    case Menu.XoaDVTheoLoai:
                        ds.Xuat();
                        Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
                        x = Console.ReadLine();
                        ds.XoaDVTheoLoai(x);
                        Console.Clear();
                        Console.WriteLine($"ds da xoa loai {x}: ");
                        ds.Xuat();
                        break;

                    case Menu.XoaDVBietBay:
                        Console.WriteLine("DS truoc khi xoa dv biet bay: ");
                        ds.Xuat();
                        Console.WriteLine("DS sau khi xoa dv biet bay: ");
                        ds.XoaDVBietBay();
                        ds.Xuat();
                        break;

                    case Menu.XoaDVKoBietBay:
                        Console.WriteLine("DS truoc khi xoa dv khong biet bay: ");
                        ds.Xuat();
                        Console.WriteLine("DS sau khi xoa dv khong biet bay: ");
                        ds.XoaDVKhongBietBay();
                        ds.Xuat();
                        break;

                    case Menu.XoaDVBietBayTheoTen:
                        ds.Xuat();
                        Console.Write("Nhap ten dv biet bay can xoa: ");
                        x = Console.ReadLine();
                        ds.XoaDVBietBayTheoTen(x);
                        Console.Clear();
                        Console.WriteLine("DS da xoa: ");
                        ds.Xuat();
                        break;

                    case Menu.XoaDVBietBayTheoTuoi:
                        ds.Xuat();
                        Console.Write("Nhap tuoi dv biet bay can xoa: ");
                        y = int.Parse(Console.ReadLine());
                        ds.XoaDVBietBayTheoTuoi(y);
                        Console.Clear();
                        Console.WriteLine("DS da xoa: ");
                        ds.Xuat();
                        break;

                    case Menu.XoaDVKoBietBayTheoTen:
                        ds.Xuat();
                        Console.Write("Nhap ten dv khong biet bay can xoa: ");
                        x = Console.ReadLine();
                        ds.XoaDVKhongBietBayTheoTen(x);
                        Console.Clear();
                        Console.WriteLine("DS da xoa: ");
                        ds.Xuat();
                        break;

                    case Menu.XoaDVKoBietBayTheoTuoi:
                        ds.Xuat();
                        Console.Write("Nhap tuoi dv khong biet bay can xoa: ");
                        y = int.Parse(Console.ReadLine());
                        ds.XoaDVKhongBietBayTheoTuoi(y);
                        Console.Clear();
                        Console.WriteLine("DS da xoa: ");
                        ds.Xuat();
                        break;

                    case Menu.XoaDVTuoiNhoNhat:
                        Console.WriteLine("DS truoc khi xoa: ");
                        ds.Xuat();
                        Console.WriteLine("DS sau khi xoa dv tuoi nho nhat: ");
                        ds.XoaDVTuoiMin();
                        ds.Xuat();
                        break;

                    case Menu.XoaDVTuoiLonNhat:
                        Console.WriteLine("DS truoc khi xoa: ");
                        ds.Xuat();
                        Console.WriteLine("DS sau khi xoa dv tuoi lon nhat: ");
                        ds.XoaDVTuoiMax();
                        ds.Xuat();
                        break;

                    case Menu.XoaDVTuoiNhoNhatTheoLoai:
                        Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
                        x = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"DS truoc khi xoa dv co tuoi nho nhat theo loai: {x}");
                        ds.Xuat();
                        Console.WriteLine($"DS sau khi xoa dv co tuoi nho nhat theo loai: {x}");
                        ds.XoaDVTuoiMinTheoLoai(x);
                        ds.Xuat();
                        break;

                    case Menu.XoaDVTuoiLonNhatTheoLoai:
                        Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
                        x = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"DS truoc khi xoa dv co tuoi lon nhat theo loai: {x}");
                        ds.Xuat();
                        Console.WriteLine($"DS sau khi xoa dv co tuoi lon nhat theo loai: {x}");
                        ds.XoaDVTuoiMaxTheoLoai(x);
                        ds.Xuat();
                        break;

                    case Menu.XoaDVTrongDS:
                        ds.Xuat();
                        Console.Write("Nhap ten dv can xoa: ");
                        x = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"DS truoc khi xoa dv {x}:");
                        ds.Xuat();
                        Console.WriteLine($"DS sau khi xoa dv {x}: ");
                        ds.XoaDVTrongDS(x);
                        ds.Xuat();
                        break;

                    case Menu.XoaDVTaiViTriX:
                        break;

                    case Menu.TinhTuoiDVTheoLoai:
                        ds.Xuat();
                        Console.Write("Nhap loai (Bat, Lion, Bird, Fish): ");
                        x = Console.ReadLine();
                        Console.WriteLine(ds.TinhTongTuoiTheoLoai(x));
                        break;

                    case Menu.TinhTongTuoiDVBietBay:
                        Console.WriteLine("Tong tuoi dv biet bay la: " + ds.TinhTongTuoiDVBietBay());
                        break;

                    case Menu.TinhTongTuoiDVKoBietBay:
                        Console.WriteLine("Tong tuoi dv khong biet bay la: " + ds.TinhTongTuoiDVKhongBietBay());
                        break;
                    case Menu.ThemDVVaoViTriX:
                        Console.Write("Nhap vi tri x: ");
                        y = int.Parse(Console.ReadLine());
                        ds.ThemDVVaoViTri(y);
                        break;
                    case Menu.HienThiDanhSachDVTangDanTheoTen:
                        ds.SapTangTheoTen();
                        ds.Xuat();
                        break;
                    case Menu.HienThiDanhSachDVGiamDanTheoTen:
                        ds.SapGiamTheoTen();
                        ds.Xuat();
                        break;
                    case Menu.HienThiDanhSachDVTangDanTheoTuoi:
                        ds.SapTangTheoTuoi();
                        ds.Xuat();
                        break;
                    case Menu.HienThiDanhSachDVGiamDanTheoTuoi:
                        ds.SapGiamTheoTuoi();
                        ds.Xuat();
                        break;
                    default:
                        return;
                }
                Console.WriteLine("Nhan 1 phim bat ky de tiep tuc !");
                Console.ReadKey();
            }
        }


    }
}
