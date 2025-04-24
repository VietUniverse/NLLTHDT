using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap1
{
    internal class QuanLyNhanVien
    {
        public List<Nguoi> collections;
        public QuanLyNhanVien() 
        {
            collections = new List<Nguoi>();
        }

        public void Nhap(Nguoi nv)
        {
            collections.Add(nv);
        }

        public void NhapThuCong(string[] a)
        {
            Nguoi nv;
            string diaChi = a[0];
            string ten = a[1];
            int tuoi = int.Parse(a[2]);
            decimal luong = decimal.Parse(a[3]);
            string maNV = a[4];
            string viTri = a[5];
            if (a.Length < 6)
            {
                nv = new NhanVien(diaChi, ten, tuoi, luong, maNV, viTri);
            }
            else
            {
                string phong = a[6];
                nv = new QuanLy(diaChi, ten, tuoi, luong, maNV, viTri, phong);
            }
            Nhap(nv);
        }

        public void ThemNV(NhanVien nv)
        {
            collections.Add(nv);
        }

        public void ThemQuanLy(QuanLy ql)
        {
            collections.Add(ql);
        }


        public void NhapTuFile()
        {
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string s;
                Nguoi nv;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] a = s.Split(',');
                    string diaChi = a[0];
                    string ten = a[1];
                    int tuoi = int.Parse(a[2]);
                    decimal luong = decimal.Parse(a[3]);
                    string maNV = a[4];
                    string viTri = a[5];
                    if (a.Length < 7)
                    {
                        nv = new NhanVien(diaChi, ten, tuoi, luong, maNV, viTri);
                    }
                    else
                    {
                        string phong = a[6];
                        nv = new QuanLy(diaChi, ten, tuoi, luong, maNV, viTri, phong);
                    }
                    Nhap(nv);
                }
            }
        }

        public void XuatDS()
        {
            foreach(var i in collections)
                Console.WriteLine(i);
        }
        public void XuatRaFile()
        {
            using (StreamWriter sw = new StreamWriter("done.txt"))
            {
                foreach (Nguoi nv in collections)
                    sw.WriteLine(nv);
            }
        }

        public int TimKiemNguoi(string ten)
        {
            for (int i = 0; i < collections.Count; i++)
            {
                if (collections[i].Ten == ten)
                {
                    return i+1;
                }
            }
            return -1;
        }
        public int TimKiemNhanVien(string maNV)
        {
            for (int i = 0; i < collections.Count; i++)
            {
                if (((NhanVien)collections[i]).MaNV == maNV)
                {
                    return i + 1;
                }
            }
            return -1;
        }
        public int TimKiemQuanLy(string phong)
        {
            for (int i = 0; i < collections.Count; i++)
            {
                if (((QuanLy)collections[i]).Phong == phong)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        public void XoaQuanLy(string phong)
        {
            collections.RemoveAt(TimKiemQuanLy(phong)-1);
        }

        public void XoaNhanVien(string maNV)
        {
            collections.RemoveAt(TimKiemNhanVien(maNV)-1);

        }

        public void XoaNguoi(string ten)
        {
            collections.RemoveAt(TimKiemNguoi(ten) - 1);

        }

        public void Swap(int i, int j)
        {
            var temp = collections[i];
            collections[i] = collections[j];
            collections[j] = temp;
        }

        public enum SapXep
        {
            tang,giam
        }


        public void SapXepNguoiTheoTen(SapXep sx)
        {
            for (int i = 0; i < collections.Count - 1; i++)
            {
                for (int j = i + 1; j < collections.Count; j++)
                {
                    if(sx == SapXep.tang)
                        if (string.Compare(collections[j].Ten, collections[i].Ten) < 0)
                            Swap(i, j);
                    else
                        if (string.Compare(collections[j].Ten, collections[i].Ten) > 0)
                            Swap(i, j);
                }
            }
        }

        public void SapXepQuanLyTheoPhong(SapXep sx)
        {
            for (int i = 0; i < collections.Count - 1; i++)
            {
                for (int j = i + 1; j < collections.Count; j++)
                {
                    if (sx == SapXep.tang)
                        if (string.Compare(((QuanLy)collections[j]).Phong, ((QuanLy)collections[i]).Phong) < 0)
                            Swap(i, j);
                        else
                        if (string.Compare(((QuanLy)collections[j]).Phong, ((QuanLy)collections[i]).Phong) > 0)
                            Swap(i, j);
                }
            }
        }

        public void SapXepNhanVienTheoMaNV(SapXep sx)
        {
            for (int i = 0; i < collections.Count - 1; i++)
            {
                for (int j = i + 1; j < collections.Count; j++)
                {
                    if (sx == SapXep.tang)
                        if (string.Compare(((NhanVien)collections[j]).MaNV, ((NhanVien)collections[i]).MaNV) < 0)
                            Swap(i, j);
                        else
                        if (string.Compare(((NhanVien)collections[j]).MaNV, ((NhanVien)collections[i]).MaNV) > 0)
                            Swap(i, j);
                }
            }
        }



    }
}



