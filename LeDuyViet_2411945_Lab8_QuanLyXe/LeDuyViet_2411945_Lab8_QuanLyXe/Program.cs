using static LeDuyViet_2411945_Lab8_QuanLyXe.DanhSachPhuongTien;

namespace LeDuyViet_2411945_Lab8_QuanLyXe
{
    internal class Program
    {
        enum menu
        {
            NhapTuFile = 1,
            Them,
            Xuat,
            TangTocDo,
            GiamTocDo,
            DongCua,
            MoCua,
            DemSoLuongTheoCar,
            DemSoLuongTheoMotorcycle,
            DemSoLuongTheoCarVaMotorcycle,
            DemSoLuongTheoTen,
            DemSoLuongTheoSCN,
            DemSoLuongTheoTocDo,
            DemSoLuongTheoTenTocDo,
            DemSoLuongTheoTenTocDoSCN,
            TimPhuongTienTheoTen,
            TimPhuongTienTheoTocDo,
            TimPhuongTienTheoSoChoNgoi,
            TimPhuongTienTheoTenTocDo,
            TimPhuongTienTheoTenSCN,
            TimPhuongTienTheoTocDoSCN,
            TimPhuongTienCoTocDoLonNhat,
            TimPhuongTienCoSoChoNgoiLonNhat,
            TimPhuongTienCoTocDoNhoNhat,
            TimPhuongTienCoSoChoNgoiNhoNhat,
            SapXepTheoTen,
            SapXepTheoTocDo,
            SapXepTheoSCN,
        }
        static void Main(string[] args)
        {
            DanhSachPhuongTien ds = new DanhSachPhuongTien();
            string s = "";
            Motorcycle xemay = new Motorcycle();
            Car oto = new Car();
            int tocDo = 0;
            int scn = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{(int)menu.NhapTuFile} de nhap thong tin tu file");
                Console.WriteLine($"{(int)menu.Them} de nhap thong tin thu cong");
                Console.WriteLine($"{(int)menu.Xuat} de xuat thong tin ra man hinh");
                Console.WriteLine($"{(int)menu.TangTocDo} de tang toc do cho xe may");
                Console.WriteLine($"{(int)menu.GiamTocDo} de giam toc do cho xe may");
                Console.WriteLine($"{(int)menu.DongCua} de dong cua oto");
                Console.WriteLine($"{(int)menu.MoCua} de mo cua oto");
                Console.WriteLine($"{(int)menu.DemSoLuongTheoCar} de dem so luong oto");
                Console.WriteLine($"{(int)menu.DemSoLuongTheoMotorcycle} de dem so luong xe may");
                Console.WriteLine($"{(int)menu.DemSoLuongTheoCarVaMotorcycle} de dem so luong xe may va xe oto");
                Console.WriteLine($"{(int)menu.DemSoLuongTheoTen} de dem so luong theo ten");
                Console.WriteLine($"{(int)menu.DemSoLuongTheoSCN} de dem so luong theo so cho ngoi");
                Console.WriteLine($"{(int)menu.DemSoLuongTheoTocDo} de dem so luong theo toc do");
                Console.WriteLine($"{(int)menu.DemSoLuongTheoTenTocDo} de dem so luong theo ten va toc do");
                Console.WriteLine($"{(int)menu.DemSoLuongTheoTenTocDoSCN} de dem so luong theo ten, toc do va so cho ngoi");
                Console.WriteLine($"{(int)menu.TimPhuongTienTheoTen} de xuat vi tri phuong tien theo ten");
                Console.WriteLine($"{(int)menu.TimPhuongTienTheoTocDo} de xuat vi tri phuong tien theo toc do");
                Console.WriteLine($"{(int)menu.TimPhuongTienTheoSoChoNgoi} de xuat vi tri phuong tien theo so cho ngoi");
                Console.WriteLine($"{(int)menu.TimPhuongTienTheoTenTocDo} de xuat vi tri phuong tien theo ten va toc do");
                Console.WriteLine($"{(int)menu.TimPhuongTienCoTocDoLonNhat} de nhap thong tin tu file");
                Console.WriteLine($"{(int)menu.TimPhuongTienCoTocDoNhoNhat} de nhap thong tin tu file");
                Console.WriteLine($"{(int)menu.TimPhuongTienCoSoChoNgoiLonNhat} de nhap thong tin tu file");
                Console.WriteLine($"{(int)menu.TimPhuongTienCoSoChoNgoiNhoNhat} de nhap thong tin tu file");
                Console.WriteLine($"{(int)menu.SapXepTheoTen} de nhap thong tin tu file");
                Console.WriteLine($"{(int)menu.SapXepTheoTocDo} de nhap thong tin tu file");
                Console.WriteLine($"{(int)menu.SapXepTheoSCN} de nhap thong tin tu file");
                Console.WriteLine();
                menu chon = (menu)int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case menu.NhapTuFile:
                        Console.WriteLine("Nhap ten file:");
                        ds.ReadFromFile(Console.ReadLine());
                        break;
                    case menu.Them:
                        Console.WriteLine("Nhap chuoi cach nhau ','");
                        s = Console.ReadLine();
                        ds.ThemThuCong(s);
                        break;
                    case menu.Xuat:
                        ds.Xuat();
                        break;
                    case menu.TangTocDo:
                        xemay.TangToc();
                        break;
                    case menu.GiamTocDo:
                        xemay.GiamToc();
                        break;
                    case menu.MoCua:
                        oto.MoCua();
                        break;
                    case menu.DongCua:
                        oto.DongCua();
                        break;
                    case menu.DemSoLuongTheoCar:
                        Console.WriteLine($"So luong oto: {ds.DemSoLuongTheoCar()}");
                        break;
                    case menu.DemSoLuongTheoMotorcycle:
                        Console.WriteLine($"So luong xe may: {ds.DemSoLuongTheoMotocycle()}");
                        break;
                    case menu.DemSoLuongTheoCarVaMotorcycle:
                        Console.WriteLine($"Tong so luong xe: {ds.DemSoLuongTheoCarVaMotorcycle()}");
                        break;
                    case menu.DemSoLuongTheoTen:
                        Console.WriteLine("Nhap ten phuong tien:");
                        s = Console.ReadLine();
                        Console.WriteLine($"So luong theo ten: {ds.DemSoLuongTheoTen(s)}");
                        break;
                    case menu.DemSoLuongTheoSCN:
                        Console.WriteLine("Nhap so cho ngoi:");
                        scn = int.Parse(Console.ReadLine());
                        Console.WriteLine($"So luong theo SCN: {ds.DemSoLuongTheoSCN(scn)}");
                        break;
                    case menu.DemSoLuongTheoTocDo:
                        Console.WriteLine("Nhap toc do:");
                        tocDo = int.Parse(Console.ReadLine());
                        Console.WriteLine($"So luong theo toc do: {ds.DemSoLuongTheoTocDo(tocDo)}");
                        break;
                    case menu.DemSoLuongTheoTenTocDo:
                        Console.WriteLine("Nhap ten:");
                        string ten = Console.ReadLine();
                        Console.WriteLine("Nhap toc do:");
                        tocDo = int.Parse(Console.ReadLine());
                        Console.WriteLine($"So luong theo ten va toc do: {ds.DemSoLuongTheoTenTocDo(ten, tocDo)}");
                        break;
                    case menu.DemSoLuongTheoTenTocDoSCN:
                        Console.WriteLine("Nhap ten:");
                        ten = Console.ReadLine();
                        Console.WriteLine("Nhap toc do:");
                        tocDo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so cho ngoi:");
                        scn = int.Parse(Console.ReadLine());
                        Console.WriteLine($"So luong theo ten, toc do, so cho ngoi: {ds.DemSoLuongTheoTenTocDoSCN(ten, tocDo, scn)}");
                        break;
                    case menu.TimPhuongTienTheoTen:
                        Console.WriteLine("Nhap ten phuong tien can tim:");
                        s = Console.ReadLine();
                        ds.TimPhuongTienTheoTen(s);
                        break;
                    case menu.TimPhuongTienTheoTocDo:
                        Console.WriteLine("Nhap toc do can tim:");
                        tocDo = int.Parse(Console.ReadLine());
                        ds.TimPhuongTienTheoTocDo(tocDo);
                        break;
                    case menu.TimPhuongTienTheoSoChoNgoi:
                        Console.WriteLine("Nhap so cho ngoi can tim:");
                        scn = int.Parse(Console.ReadLine());
                        ds.TimPhuongTienTheoSoChoNgoi(scn);
                        break;
                    case menu.TimPhuongTienTheoTenTocDo:
                        Console.WriteLine("Nhap ten:");
                        ten = Console.ReadLine();
                        Console.WriteLine("Nhap toc do:");
                        tocDo = int.Parse(Console.ReadLine());
                        ds.TimPhuongTienTheoTenTocDo(ten, tocDo);
                        break;
                    case menu.TimPhuongTienTheoTenSCN:
                        Console.WriteLine("Nhap ten:");
                        ten = Console.ReadLine();
                        Console.WriteLine("Nhap so cho ngoi:");
                        scn = int.Parse(Console.ReadLine());
                        ds.TimPhuongTienTheoTenSCN(ten, scn);
                        break;
                    case menu.TimPhuongTienTheoTocDoSCN:
                        Console.WriteLine("Nhap toc do:");
                        tocDo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap so cho ngoi:");
                        scn = int.Parse(Console.ReadLine());
                        ds.TimPhuongTienTheoTocDoSCN(tocDo, scn);
                        break;
                    case menu.TimPhuongTienCoTocDoLonNhat:
                        ds.TimPhuongTienCoTocDoLonNhat();
                        break;
                    case menu.TimPhuongTienCoTocDoNhoNhat:
                        ds.TimPhuongTienCoTocDoNhoNhat();
                        break;
                    case menu.TimPhuongTienCoSoChoNgoiLonNhat:
                        ds.TimPhuongTienCoSoChoNgoiLonNhat();
                        break;
                    case menu.TimPhuongTienCoSoChoNgoiNhoNhat:
                        ds.TimPhuongTienCoSoChoNgoiNhoNhat();
                        break;
                    case menu.SapXepTheoTen:
                        Console.WriteLine("1. Tang dan | 2. Giam dan:");
                        int luaChonTen = int.Parse(Console.ReadLine());
                        ds.SapXepTheoTen((SapXep)luaChonTen - 1);
                        ds.Xuat();
                        break;
                    case menu.SapXepTheoTocDo:
                        Console.WriteLine("1. Tang dan | 2. Giam dan:");
                        int luaChonTocDo = int.Parse(Console.ReadLine());
                        ds.SapXepTheoTocDo((SapXep)luaChonTocDo - 1);
                        ds.Xuat();
                        break;
                    case menu.SapXepTheoSCN:
                        Console.WriteLine("1. Tang dan | 2. Giam dan:");
                        int luaChonSCN = int.Parse(Console.ReadLine());
                        ds.SapXepTheoSoChoNgoi((SapXep)luaChonSCN - 1);
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