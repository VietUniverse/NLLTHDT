using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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

    }

    static bool KiemTraX(List<int> ds, int x)
    {
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] == x)
                return true;
        return false;
    }

    static int TimSoLanXuatHien(List<int> ds, int x)//2.10
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == x)
                count++;
        }

    }

    static bool SoHoanHao(int x)
    {
        int sum = 0;
        for (int i = 0; i < (int)Math.Sqrt(x); i++)
        {
            if (x % i == 0)
                sum += i;
        }
        if (sum == x) return true;
        return false;
    }

    static List<int> TimSoHoanHao(List<int> ds)
    {
        List<int> res = new List<int>();
        foreach (int i in ds)
        {
            if (SoHoanHao(i)) res.Add(i);
        }
        return res;
    }

    static int UCLNT(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int UCLNA(List<int> ds)
    {
        int result = ds[0];
        for (int i = 1; i < ds.Count; i++)
        {
            result = UCLNT(result, ds[i]);

            if (result == 1)
                return 1;
        }
        return result;
    }

    static int BCNNT(int a, int b)
    {
        return (a / UCLNT(a, b)) * b;
    }

    static int BCNNA(List<int> ds)
    {
        int result = ds[0];
        for (int i = 1; i < ds.Count; i++)
        {
            result = BCNNT(result, ds[i]);
        }
        return result;
    }

    static bool KiemTraDuong(List<int> ds)
    {
        foreach (int i in ds)
        {
            if (i < 0) return false;
        }
        return true;
    }

    static bool KiemTraAm(List<int> ds)
    {
        foreach (int i in ds)
        {
            if (i > 0) return false;
        }
        return true;
    }

    static bool KiemTraNT(int x)
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

    static int DemNT(List<int> ds)
    {
        int count = 0;
        foreach (int i in ds)
        {
            if (KiemTraNT(i))
                count++;
        }
        return count;
    }

    static bool KTSoDoiXung(int x)
    {
        string data = x.ToString();
        for (int i = data.Length - 1; i > -1; i--)
        {
            if (data[i] != data[data.Length - 1 - i])
                return false;
        }
        return true;
    }

    static int DemDoiXung(List<int> ds)
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
            if (KTSoDoiXung(ds[i]))
                count++;
        return count;
    }
    static int DemHieuChan(List<int> ds, int x)
    {
        int count = 0;
        foreach (int i in ds)
            if ((i - x) % 2 == 0)
                count++;
        return count;
    }

    static List<int> TimLe(List<int> ds)
    {
        List<int> list = new List<int>();
        foreach (int i in ds)
        {
            if (i % 2 != 0)
                list.Add(i);
        }
        return list;
    }

    static List<int> TimChan(List<int> ds)
    {
        List<int> list = new List<int>;
        foreach (int i in ds)
        {
            if (i % 2 == 0)
                list.Add(i);
        }
        return list;
    }

    static void TimHieuChan(List<int> ds)
    {
        List<int> chan = new List<int>();
        List<int> le = new List<int>();
        chan = TimChan(ds);
        le = TimLe(ds);
        for (int i = 0; i < chan.Count - 2; i++)
        {
            Console.WriteLine($"({chan[i]}, {chan[i + 1]})");
        }
        for (int i = 0; i < le.Count - 2; i++)
        {
            Console.WriteLine($"({le[i]}, {le[i + 1]})");
        }

    }

    static bool KiemTraCoLe(List<int> ds)
    {
        foreach (int i in ds)
            if (i % 2 != 0)
                return true;
        return false;
    }

    static int TongBinhPhuong(List<int> ds)
    {
        int sum = 0;
        foreach (int i in ds)
            sum += Math.Pow(i, 2);
        return sum;
    }
    static int TimSoLanXuatHien(List<int> ds, int x)//2.10
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == x)
                count++;
        }
        return count;

    }
    static int TimXuatHienNhieuNhat(List<int> ds) //3.10
    {
        int max = 0, res;
        foreach (int i in ds)
            if (TimSoLanXuatHien(ds, i) > max)
            {
                max = TimSoLanXuatHien(ds, i);
                res = i;
            }
        return res;

    }

    static bool KiemTraTang(List<int> ds)
    {
        for(int i = 0;i < ds.Count-2;i++)
            if (ds[i] > ds[i+1])
                return false;
     
        return true;
    }
    static bool KiemTraGiam(List<int> ds)
    {
        for (int i = 0; i < ds.Count - 2; i++)
            if (ds[i] < ds[i + 1])
                return false;
        return true;
    }

    static bool KiemTraChiaHet(List<int> ds, int x)
    {
        foreach (int i in ds)
        {
            if(i % x != 0)
                return false;
        }
        return true;
    }

    static int TongNT(List<int> ds)
    {
        int sum = 0;
        foreach (int i in ds)
            if (KiemTraNT(i))
                sum += i;
        return sum;
    }

    static int DemBeHonX(List<int> ds, int x)
    {
        int count = 0;
        foreach(int i in ds)
        {
            if(i < x)
                count++;
        }
        return count;
    }

    static void SapXepTangDan(List<int> ds)
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
    static void SapXepGiamDan(List<int> ds)
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
    static void SapXepDuongTang(List<int> ds)
    {
        int temp;
        for (int i = 0; i < ds.Count - 1; i++)
            for (int j = i + 1; j < ds.Count; j++)
                if (ds[i] < ds[j] && ds[i] > 0 && ds[j] > 0)
                {
                    temp = ds[i];
                    ds[i] = ds[j];
                    ds[j] = temp;
                }
    }

    static int TimSoLonNhi(List<int> ds)
    {
        SapXepGiamDan(ds);
        return ds[1];
    }
    static int TimSoNhoNhi(List<int> ds)
    {
        SapXepGiamDan(ds);
        return ds[ds.Count-2];
    }


}