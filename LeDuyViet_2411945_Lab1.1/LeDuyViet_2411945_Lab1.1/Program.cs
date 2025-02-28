using System;
using System.Diagnostics;
using System.Numerics;


namespace C_firstprogram;
internal class Program
{
    static void Main(string[] args)
    {
        List<int> a = new List<int>();
        NhapTuFile(a);
        XuatRaFile(a);
    }
    static void NhapTuBanPhim(List<int> ds)  //1.1
    {
        Console.WriteLine("Nhap vao so phan tu cua mang ");
        var soPT = int.Parse(Console.ReadLine());
        for (int i = 0; i < soPT; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            ds.Add(int.Parse(Console.ReadLine()));
        }
    }
    static void NhapTuDong(List<int> ds) //1.2
    {
        Console.WriteLine("Nhap vao so phan tu cua mang ");
        var soPT = int.Parse(Console.ReadLine());
        Random numran = new Random();
        for (int i = 0; i < soPT; i++)
        {
            ds.Add(numran.Next(1000));
        }
    }

    //static void NhapTuFile(List<int> ds) //1.3
    //{
    //    using (StreamReader sr = new StreamReader("input.txt"))
    //    {
    //        var soPT = int.Parse(sr.ReadLine());
    //        var data = sr.ReadLine().Split(' ');
    //        for (int i = 0; i < soPT; i++)
    //        {
    //            ds.Add(int.Parse(data[i]));
    //        }
    //    }
    //}

    static List<int> NhapTuFile(List<int> ds)
    {
        using (StreamReader file = new StreamReader("input.txt"))
        {
            var line = file.ReadLine().Split(' ');

            for (int i = 0; i < line.Length; i++)
            {

                ds.Add(int.Parse(line[i]));
            }

            return ds;
        }
    }

    static void Xuat(List<int> ds) //1.4
    {
        for (int i = 0; i < ds.Count; i++)
        {
            Console.Write(ds[i] + " ");
        }
        Console.WriteLine();
    }

    static void XuatRaFile(List<int> ds) //1.5
    {
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            for (int i = 0; i < ds.Count; i++)
            {
                sw.Write(ds[i] + " ");
            }
            sw.Write('\n');
        }
    }
    static int TinhTong(List<int> ds) //2.1
    {
        return ds.Sum();
    }

    static double TinhTrungBinh(List<int> ds) //2.2
    {
        return ds.Average();
    }

    static int TimMax(List<int> ds) //2.3
    {
        return ds.Max();
    }

    static int TimMin(List<int> ds)//2.4
    {
        return ds.Min();
    }

    static int TimSoLanXuatHien(List<int> ds, int x)//2.5
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == x)
                count++;
        }
        return count;
    }

    static int TinhTongAm(List<int> ds)//2.6
    {
        int sum = 0;
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] < 0)
                sum += ds[i];
        return sum;
    }

    static int TinhTongDuong(List<int> ds)//2.7
    {
        int sum = 0;
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] > 0)
                sum += ds[i];
        return sum;
    }

    static int DemSoChan(List<int> ds)//2.8
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] % 2 == 0)
                count++;
        return count;
    }

    static int DemSoLe(List<int> ds)//2.9
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] % 2 != 0)
                count++;
        return count;
    }

    static int DemX(List<int> ds, int x)//2.10
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == x)
                count++;
        }
        return count;
    }

    static bool KiemTraX(List<int> ds, int x)
    {
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] == x)
                return true;
        return false;
    }

    static List<int> TimViTriX(List<int> ds, int x) //3.1
    {
        List<int> tmp = new List<int>();
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == x)
                tmp.Add(i + 1);
        }
        return tmp;
    }

    static int TimViTriDauTien(List<int> ds, int x) //3.2
    {
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == x)
                return i + 1;
        }
        return -1;
    }

    static int TimViTriCuoiCung(List<int> ds, int x) //3.3
    {
        for (int i = ds.Count - 1; i > -1; i--)
        {
            if (ds[i] == x) return i + 1;
        }
        return -1;
    }
    static List<int> ViTriCacSoDuong(List<int> ds) //3.4
    {
        List<int> vt = new List<int>();
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] > 0)
            {
                vt.Add(i + 1);
            }
        }
        return vt;
    }

    static List<int> ViTriCacSoAm(List<int> ds) //3.5
    {
        List<int> vt = new List<int>();
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] < 0)
            {
                vt.Add(i + 1);
            }
        }
        return vt;
    }

    static List<int> ViTriCacSoLonNhat(List<int> ds) //3.6
    {
        int max = TimMax(ds);
        List<int> vt = new List<int>();
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == max)
                vt.Add(i);
        }
        return vt;
    }

    static List<int> ViTriCacSoNhoNhat(List<int> ds) //3.7
    {
        int min = TimMin(ds);
        List<int> vt = new List<int>();
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == min) vt.Add(i);
        }
        return vt;
    }

    static List<int> ViTriCacSoChan(List<int> ds)  //3.8
    {
        List<int> vt = new List<int>();
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] % 2 == 0) vt.Add(i);
        }
        return vt;
    }

    static List<int> ViTriCacSoLe(List<int> ds) //3.9
    {
        List<int> vt = new List<int>();
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] % 2 != 0) vt.Add(i);
        }
        return vt;
    }


    static int TimSoNguyenXuatHienNhieuNhat(List<int> ds) //3.10
    {
        int max = 0, res = 0;
        foreach (int i in ds)
            if (TimSoLanXuatHien(ds, i) > max)
            {
                max = TimSoLanXuatHien(ds, i);
                res = i;
            }
        return res;
    }
    static int TimSoNguyenXuatHienItNhat(List<int> ds) //3.11
    {
        int min = int.MaxValue, res = 0;
        foreach (int i in ds)
            if (TimSoLanXuatHien(ds, i) < min)
            {
                min = TimSoLanXuatHien(ds, i);
                res = i;
            }
        return res;
    }

    static bool KiemTra(List<int> ds, int x) //3.12
    {
        foreach (int i in ds)
            if (i == x)
            {
                return false;
            }
        return true;
    }

    static List<int> TimKhongTrung(List<int> ds) //3.13
    {
        List<int> res = new List<int>();
        foreach (int i in ds)
        {
            if (KiemTra(res, i)) res.Add(i);
        }
        return res;
    }

    static List<int> TimSoLanXuatHienCacPhanTu(List<int> ds) //3.14
    {
        List<int> data = new List<int>();
        data = TimKhongTrung(ds);
        List<int> res = new List<int>();
        foreach (int i in data)
        {
            res.Add(TimSoLanXuatHien(ds, i));
        }
        return res;
    }
    static int FindFirstOccurrence(List<int> mainList, List<int> subList) //3.16
    {
        if (subList == null || subList.Count == 0 || mainList == null || mainList.Count < subList.Count)
        {
            return -1;
        }

        for (int i = 0; i <= mainList.Count - subList.Count; i++)
        {
            bool match = true;
            for (int j = 0; j < subList.Count; j++)
            {
                if (mainList[i + j] != subList[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                return i + 1;
            }
        }
        return -1;
    }

    static void SapXepTangDan(List<int> ds) //4.1
    {
        int temp;
        for (int i = 0; i < ds.Count - 1; i++)
            for (int j = i + 1; j < ds.Count; j++)
                if (ds[i] > ds[j])
                {
                    temp = ds[i];
                    ds[i] = ds[j];
                    ds[j] = temp;
                }
    }
    static void SapXepGiamDan(List<int> ds) //4.2
    {
        int temp;
        for (int i = 0; i < ds.Count - 1; i++)
            for (int j = i + 1; j < ds.Count; j++)
                if (ds[i] < ds[j])
                {
                    temp = ds[i];
                    ds[i] = ds[j];
                    ds[j] = temp;
                }
    }

    static void XoaPhanTu(List<int> ds, int vt) //5.1
    {
        ds.RemoveAt(vt);
    }

    static void XoaDau(List<int> ds) //5.2
    { ds.RemoveAt(0); }
    static void XoaDuoi(List<int> ds) //5.3
    { ds.RemoveAt(ds.Count - 1); }
    static void XoaDanhSach(List<int> ds) //5.4
    { ds.Clear(); }
    static void XoaLonHonX(List<int> ds, int x) //5.5
    {
        foreach (var i in ds)
        {
            if (i > x)
                ds.Remove(i);
        }
    }
    static void XoaDuong(List<int> ds) //5.6
    {
        foreach (var i in ds)
        {
            if (i > 0)
                ds.Remove(i);
        }
    }

    static void XoaAm(List<int> ds) //5.7
    {
        foreach (var i in ds)
        {
            if (i < 0)
                ds.Remove(i);
        }
    }


    static void XoaChan(List<int> ds) //5.8
    {
        foreach (var i in ds)
        {
            if (i % 2 == 0)
                ds.Remove(i);
        }
    }

    static bool KiemTraNT(int x) //5.9
    {
        if (x < 2)
        {
            return false;
        }
        else
        {
            for (int i = 1; i < (int)Math.Sqrt(x); i++)
                if (x % i == 0)
                    return false;
            return true;
        }
    }


    static void XoaNguyenTo(List<int> ds) //5.10
    {
        foreach (var i in ds)
        {
            if (KiemTraNT(i))
                ds.Remove(i);
        }
    }

    static void ThemX(List<int> ds, int x, int vt) //5.11
    {
        ds.Insert(vt, x);
    }

    static void ThemDau(List<int> ds, int x) //5.12
    {
        ds.Insert(0, x);

    }

    static void ThemDuoi(List<int> ds, int x) //5.13
    {
        ds.Insert(ds.Count - 1, x);
    }

    static void ThemDanhSach(List<int> ds, List<int> data, int vt) //5.14
    {
        int j = 0;
        for (int i = vt; i < ds.Count; i++)
        {
            ds.Insert(i, data[j++]);
        }
    }

    static List<int> DaoNguoc(List<int> ds) //5.15
    {
        List<int> res = new List<int>();
        for (int i = ds.Count - 1; i >= 0; i--)
            res.Add(ds[i]);
        return res;
    }

    static void DaoLon(List<int> ds) //5.16
    {
        Random rd = new Random();
        for (int i = 0; i < ds.Count; i++)
            ds[i] = ds[rd.Next(0, ds.Count)];
    }

    static void ThayThe(List<int> ds, int x, int y) //5.17
    {
        ds[ds.IndexOf(x)] = y;
    }
}