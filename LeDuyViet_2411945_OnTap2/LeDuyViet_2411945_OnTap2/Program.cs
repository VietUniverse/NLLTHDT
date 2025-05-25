namespace LeDuyViet_2411945_OnTap2
{
    internal class Program
    {
        enum menu
        {
            ThemThuCong = 1,
            DocTuFile,
            XuatRaFile,
            TimKiemTheoTen,
            TimKiemTheoHoTen,
            TimKiemTheoPhong,
            TimKiemTheoID,
            SapXepTheoTen,
            SapXepTheoHoTen,
            SapXepTheoPhong,
            SapXepTheoID,
            SuaThongTin,
            Xoa,
            LocNhanVienThuocPhong,
            LocNhanVienTheoTen,
            HienThiTongLuongNhanVien,
            Thoat
        }
        static void Main(string[] args)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Chon {(int)menu.ThemThuCong} de them thu cong");
                Console.WriteLine($"Chon {(int)menu.DocTuFile} de doc tu file");
                Console.WriteLine($"Chon {(int)menu.XuatRaFile} de xuat ra file");
                Console.WriteLine($"Chon {(int)menu.TimKiemTheoTen} de tim kiem theo ten");
                Console.WriteLine($"Chon {(int)menu.TimKiemTheoHoTen} de tim kiem theo ho va ten");
                Console.WriteLine($"Chon {(int)menu.TimKiemTheoPhong} de tim kiem theo phong");
                Console.WriteLine($"Chon {(int)menu.TimKiemTheoID} de tim kiem theo ID");
                Console.WriteLine($"Chon {(int)menu.SapXepTheoTen} de sap xep theo ten");
                Console.WriteLine($"Chon {(int)menu.SapXepTheoHoTen} de sap xep theo ho ten (chua co code)");
                Console.WriteLine($"Chon {(int)menu.SapXepTheoPhong} de sap xep theo phong");
                Console.WriteLine($"Chon {(int)menu.SapXepTheoID} de sap xep theo ID");
                Console.WriteLine($"Chon {(int)menu.SuaThongTin} de sua thong tin nhan vien");
                Console.WriteLine($"Chon {(int)menu.Xoa} de xoa nhan vien");
                Console.WriteLine($"Chon {(int)menu.LocNhanVienThuocPhong} de loc nhan vien thuoc phong");
                Console.WriteLine($"Chon {(int)menu.LocNhanVienTheoTen} de loc nhan vien theo ten");
                Console.WriteLine($"Chon {(int)menu.HienThiTongLuongNhanVien} de hien thi tong luong nhan vien");
                Console.WriteLine($"Chon {(int)menu.Thoat} de thoat");

                Console.Write("Nhap lua chon: ");

                menu chon = (menu)int.Parse(Console.ReadLine());
                string s;
                string[] line;
                int id;
                float tongLuong;
                string ho, ten, phong, data;
                List<int> result;
                int vt;
                DanhSachNhanVien.SapXep sapxep;
                DanhSachNhanVien.nhanvien loainv;

                switch (chon)
                {
                    case menu.ThemThuCong:
                        Console.WriteLine("Nhap theo dang: Ho,Ten,ID,Phong,Luong");
                        s = Console.ReadLine();
                        line = s.Split(',');
                        ds.ThemThuCong(line[0], line[1], int.Parse(line[2]), line[3], float.Parse(line[4]));
                        break;
                    case menu.DocTuFile:
                        ds.DocTuFile();
                        Console.WriteLine("Doc file thanh cong!");
                        break;
                    case menu.XuatRaFile:
                        ds.XuatRaFile();
                        Console.WriteLine("Xuat file thanh cong!");
                        break;
                    case menu.TimKiemTheoTen:
                        Console.Write("Nhap Ten can tim: ");
                        ten = Console.ReadLine();
                        result = ds.TimKiemTheoTen(ten);
                        if (result.Count == 0)
                            Console.WriteLine("Khong tim thay!");
                        else
                            foreach (var index in result)
                                Console.WriteLine(((QuanLy)ds.employees[index]).LayThongTinChiTiet());
                        break;
                    case menu.TimKiemTheoHoTen:
                        Console.Write("Nhap Ho: ");
                        ho = Console.ReadLine();
                        Console.Write("Nhap Ten: ");
                        ten = Console.ReadLine();
                        result = ds.TimKiemTheoHoTen(ho, ten);
                        if (result.Count == 0)
                            Console.WriteLine("Khong tim thay!");
                        else
                            foreach (var index in result)
                                Console.WriteLine(((QuanLy)ds.employees[index]).LayThongTinChiTiet());
                        break;
                    case menu.TimKiemTheoPhong:
                        Console.Write("Nhap Phong: ");
                        phong = Console.ReadLine();
                        result = ds.TimKiemTheoPhong(phong);
                        if (result.Count == 0)
                            Console.WriteLine("Khong tim thay!");
                        else
                            foreach (var index in result)
                                Console.WriteLine(((QuanLy)ds.employees[index]).LayThongTinChiTiet());
                        break;
                    case menu.TimKiemTheoID:
                        Console.Write("Nhap ID can tim: ");
                        id = int.Parse(Console.ReadLine());
                        vt = ds.TimKiemTheoID(id);
                        if (vt == -1)
                            Console.WriteLine("Khong tim thay!");
                        else
                            Console.WriteLine(((QuanLy)ds.employees[vt]).LayThongTinChiTiet());
                        break;
                    case menu.SapXepTheoTen:
                        Console.Write("Chon 0: tang dan, 1: giam dan: ");
                        sapxep = (DanhSachNhanVien.SapXep)int.Parse(Console.ReadLine());
                        ds.SapXepTheoTen(sapxep);
                        Console.WriteLine("Sap xep xong!");
                        ds.XuatDanhSachNhanVien();
                        break;
                    case menu.SapXepTheoPhong:
                        Console.Write("Chon 0: tang dan, 1: giam dan: ");
                        sapxep = (DanhSachNhanVien.SapXep)int.Parse(Console.ReadLine());
                        ds.SapXepTheoPhong(sapxep);
                        Console.WriteLine("Sap xep xong!");
                        ds.XuatDanhSachNhanVien();
                        break;
                    case menu.SapXepTheoID:
                        Console.Write("Chon 0: tang dan, 1: giam dan: ");
                        sapxep = (DanhSachNhanVien.SapXep)int.Parse(Console.ReadLine());
                        ds.SapXepTheoID(sapxep);
                        Console.WriteLine("Sap xep xong!");
                        ds.XuatDanhSachNhanVien();
                        break;
                    case menu.SuaThongTin:
                        Console.Write("Nhap ID nhan vien can sua: ");
                        id = int.Parse(Console.ReadLine());
                        vt = ds.TimKiemTheoID(id);
                        if (vt == -1)
                        {
                            Console.WriteLine("Khong tim thay nhan vien!");
                        }
                        else
                        {
                            Console.WriteLine("Chon muc can sua: 0: Ho, 1: Ten, 2: ID, 3: Phong");
                            loainv = (DanhSachNhanVien.nhanvien)int.Parse(Console.ReadLine());
                            Console.Write("Nhap gia tri moi: ");
                            data = Console.ReadLine();
                            ds.CapNhatThongTin(vt, loainv, data);
                            Console.WriteLine("Sua thong tin thanh cong!");
                        }
                        break;
                    case menu.Xoa:
                        Console.Write("Nhap ID nhan vien can xoa: ");
                        id = int.Parse(Console.ReadLine());
                        vt = ds.TimKiemTheoID(id);
                        if (vt == -1)
                        {
                            Console.WriteLine("Khong tim thay nhan vien!");
                        }
                        else
                        {
                            ds.Xoa(vt);
                            Console.WriteLine("Xoa thanh cong!");
                        }
                        break;
                    case menu.LocNhanVienThuocPhong:
                        Console.Write("Nhap Phong muon loc: ");
                        phong = Console.ReadLine();
                        ds.LocNhanVienThuocPhong(phong);
                        break;

                    case menu.LocNhanVienTheoTen:
                        Console.Write("Nhap Ten muon loc: ");
                        ten = Console.ReadLine();
                        ds.LocNhanVienTheoTen(ten);
                        break;

                    case menu.HienThiTongLuongNhanVien:
                        tongLuong = ds.TinhTongLuong();
                        Console.WriteLine($"Tong luong cua tat ca nhan vien: {tongLuong}");
                        break;
                    default:
                        return;
                }
                Console.WriteLine("Nhan 1 phim bat ky de tiep tuc");
                Console.ReadKey();
            }
        }

    }
}