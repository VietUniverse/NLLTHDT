namespace LeDuyViet_2411945_OnTap1
{
    internal class Program
    {
        enum menu
        {
            NhapNV = 1,
            NhapTuFile,
            XuatDanhSach,
            XuatRaFile,
            TimKiemNguoi,
            TimKiemNhanVien,
            TimKiemQuanLy,
            XoaQuanLy,
            XoaNhanVien,
            XoaNguoi,
            SapXepNguoiTheoTen,
            SapXepQuanLyTheoPhong,
            SapXepNhanVienTheoMaNV
        }
        static void Main(string[] args)
        {
            QuanLyNhanVien ds = new QuanLyNhanVien();
            string[] s;
            string name,maNV,phong;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Nhap {(int)menu.NhapNV} de nhap thong tin thu cong");
                Console.WriteLine($"Nhap {(int)menu.NhapTuFile} de nhap thong tin tu file");
                Console.WriteLine($"Nhap {(int)menu.XuatDanhSach} de xuat danh sach");
                Console.WriteLine($"Nhap {(int)menu.XuatRaFile} de xuat ra file");
                Console.WriteLine($"Nhap {(int)menu.TimKiemNguoi} de tim vi tri cua nguoi theo ten");
                Console.WriteLine($"Nhap {(int)menu.TimKiemNhanVien} de tim vi tri cua nhan vien theo maNV");
                Console.WriteLine($"Nhap {(int)menu.TimKiemQuanLy} de tim vi tri cua quan ly theo phong");
                Console.WriteLine($"Nhap {(int)menu.XoaNguoi} de xoa nguoi theo ten");
                Console.WriteLine($"Nhap {(int)menu.XoaNhanVien} de xoa nhan vien theo maNV");
                Console.WriteLine($"Nhap {(int)menu.XoaQuanLy} de xoa quan ly theo phong");
                menu chon = (menu)int.Parse(Console.ReadLine());
                switch (chon) 
                {
                    case menu.NhapNV:
                        s = Console.ReadLine().Split(',');
                        ds.NhapThuCong(s);
                        break;
                    case menu.NhapTuFile:
                        ds.NhapTuFile();
                        break;
                    case menu.XuatDanhSach:
                        ds.XuatDS();
                        break;
                    case menu.XuatRaFile:
                        ds.XuatRaFile();
                        break;
                    case menu.TimKiemNguoi:
                        Console.WriteLine("Nhap ten ");
                        name = Console.ReadLine();
                        Console.WriteLine(ds.TimKiemNguoi(name));
                        break;
                    case menu.TimKiemNhanVien:
                        Console.WriteLine("Nhap maNV ");
                        maNV = Console.ReadLine();
                        Console.WriteLine(ds.TimKiemNhanVien(maNV));
                        break;
                    case menu.TimKiemQuanLy:
                        Console.WriteLine("Nhap phong ");
                        phong = Console.ReadLine();
                        Console.WriteLine(ds.TimKiemQuanLy(phong));
                        break;
                    case menu.XoaNhanVien:
                        Console.WriteLine("Nhap maNV ");
                        maNV = Console.ReadLine();
                        ds.XoaNhanVien(maNV);
                        break;
                    case menu.XoaQuanLy:
                        Console.WriteLine("Nhap phong ");
                        phong = Console.ReadLine();
                        ds.XoaQuanLy(phong);
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