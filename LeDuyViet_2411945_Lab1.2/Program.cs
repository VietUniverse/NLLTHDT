using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;


namespace C_firstprogram;
internal class Program
{
    static void Main(string[] args)
    {
        List<int> a = new List<int> { 1, 1, 1, 2, 3, 1, 1, 1, 2, 4, 4, 1, 1};
        Console.WriteLine("Day con tang dai nhat co do dai la " + DemSoLanXXuatHienLienTiep(a,1));


    }
    static void NhapTuBanPhim(List<int> ds) //1.1
    {
        Console.WriteLine("Nhap vao so phan tu cua mang ");
        var soPT = int.Parse(Console.ReadLine());
        for (int i = 0; i < soPT; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            ds.Add(int.Parse(Console.ReadLine()));
        }
    }
    static void NhapTuDong(List<int> ds) //1.1
    {
        Console.WriteLine("Nhap vao so phan tu cua mang ");
        var soPT = int.Parse(Console.ReadLine());
        Random numran = new Random();
        for (int i = 0; i < soPT; i++)
        {
            ds.Add(numran.Next(1000));
        }
    }
    static int TinhTong(List<int> ds)  //1.4
    {
        return ds.Sum();
    }

    static double TinhTrungBinh(List<int> ds)  //1.5
    {
        return ds.Average();
    }

    static int TimMax(List<int> ds) //1.2
    {
        return ds.Max();
    }

    static int TimMin(List<int> ds) //1.3
    {
        return ds.Min();
    }

    public int TimViTriDauTienMax(List<int> ds)  //1.8
    {
        return ds.IndexOf(TimMax(ds));
    }

    public int TimViTriDauTienMin(List<int> ds)   //1.9
    {
        return ds.IndexOf(TimMin(ds));
    }

    static int TimSoLanXuatHien(List<int> ds, int x)
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == x)
                count++;
        }
        return count;
    }

    static int TinhTongAm(List<int> ds)
    {
        int sum = 0;
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] < 0)
                sum += ds[i];
        return sum;
    }

    static int TinhTongDuong(List<int> ds)
    {
        int sum = 0;
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] > 0)
                sum += ds[i];
        return sum;
    }

    static int DemSoChan(List<int> ds) //1.6
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] % 2 == 0)
                count++;
        return count;
    }

    static int DemSoLe(List<int> ds)  //1.7
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] % 2 != 0)
                count++;
        return count;
    }

    static int DemX(List<int> ds, int x)   //1.11
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == x)
                count++;
        }
        return count;

    }

    static bool KiemTraX(List<int> ds, int x)  //1.10
    {
        for (int i = 0; i < ds.Count; i++)
            if (ds[i] == x)
                return true;
        return false;
    }


    static bool SoHoanHao(int x)
    {
        int sum = 0;
        for (int i = 1; i < (int)Math.Sqrt(x); i++)
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

    static int TimHoanHaoMin(List<int> ds)  //1.13
    {
        int res = int.MaxValue;
        foreach (int i in ds) {
            if (SoHoanHao(i) && i < res)
                res = i;
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

    static int UCLNA(List<int> ds)   //1.14
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

    static int BCNNA(List<int> ds)   //1.15
    {
        int result = ds[0];
        for (int i = 1; i < ds.Count; i++)
        {
            result = BCNNT(result, ds[i]);
        }
        return result;
    }

    static bool KiemTraDuong(List<int> ds)  //1.16
    {
        foreach (int i in ds)
        {
            if (i < 0) return false;
        }
        return true;
    }

    static bool KiemTraAm(List<int> ds)   //1.17
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
            for (int i = 2; i < (int)Math.Sqrt(x); i++)
                if (x % i == 0)
                    return false;
            return true;
        }
    }

    static int DemNT(List<int> ds)   //1.18
    {
        int count = 0;
        foreach (int i in ds)
        {
            if (KiemTraNT(i))
                count++;
        }
        return count;
    }

    static List<int> TimNT(List<int> ds)  //1.12
    {
        List<int> result = new List<int>();
        foreach (int i in ds)
        {
            if (!KiemTraNT(i))
                result.Add(i);
        }
        return result;
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

    static int DemDoiXung(List<int> ds)   //1.19
    {
        int count = 0;
        for (int i = 0; i < ds.Count; i++)
            if (KTSoDoiXung(ds[i]))
                count++;
        return count;
    }

    static int TongDuong(List<int> ds) //1.20
    {
        int sum = 0;
        foreach (int i in ds)
        {
            if (i > 0)
                sum += i;
        }
        return sum;
    }


    static int TongAm(List<int> ds)  //1.21
    {
        int sum = 0;
        foreach (int i in ds)
        {
            if (i < 0)
                sum += i;
        }
        return sum;
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
        List<int> list = new List<int>();
        foreach (int i in ds)
        {
            if (i % 2 == 0)
                list.Add(i);
        }
        return list;
    }

    static void TimHieuChan(List<int> ds)    //1.22
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

    static bool KiemTraCoLe(List<int> ds)   //1.23
    {
        foreach (int i in ds)
            if (i % 2 != 0)
                return true;
        return false;
    }

    static int TongBinhPhuong(List<int> ds)   //1.24
    {
        int sum = 0;
        foreach (int i in ds)
            sum += (int)Math.Pow(i, 2);
        return sum;
    }

    static int TimXuatHienNhieuNhat(List<int> ds) //1.25
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

    static bool KiemTraTang(List<int> ds)    //1.26
    {
        for (int i = 0; i < ds.Count - 2; i++)
            if (ds[i] > ds[i + 1])
                return false;

        return true;
    }
    static bool KiemTraGiam(List<int> ds)   //1.27
    {
        for (int i = 0; i < ds.Count - 2; i++)
            if (ds[i] < ds[i + 1])
                return false;
        return true;
    }

    static bool KiemTraChiaHet(List<int> ds, int x)  //1.28
    {
        foreach (int i in ds)
        {
            if (i % x != 0)
                return false;
        }
        return true;
    }

    static int TongNT(List<int> ds)   //1.29
    {
        int sum = 0;
        foreach (int i in ds)
            if (KiemTraNT(i))
                sum += i;
        return sum;
    }

    static int DemBeHonX(List<int> ds, int x)   //1.30
    {
        int count = 0;
        foreach (int i in ds)
        {
            if (i < x)
                count++;
        }
        return count;
    }

    static void SapXepTangDan(List<int> ds)   //2.1
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
    static void SapXepGiamDan(List<int> ds)    //2.2
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
    static void SapXepLeTang(List<int> ds)    //2.3
    {
        int temp;
        for (int i = 0; i < ds.Count - 1; i++)
            for (int j = i + 1; j < ds.Count; j++)
                if (ds[i] < ds[j] && ds[i] > 0 && ds[j] % 2 != 0 && ds[i] % 2 != 0)
                {
                    temp = ds[i];
                    ds[i] = ds[j];
                    ds[j] = temp;
                }
    }

    static int TimSoLonNhi(List<int> ds)    //2.4
    {
        SapXepGiamDan(ds);
        return ds[1];
    }
    static int TimSoNhoNhi(List<int> ds)   //2.5
    {
        SapXepGiamDan(ds);
        return ds[ds.Count - 2];
    }

    static List<List<int>> TimCapCoTongX(List<int> ds, int x)    //2.6
    {
        List<List<int>> pairs = new List<List<int>>();
        for (int i = 0; i < ds.Count; i++)
        {
            for (int j = i + 1; j < ds.Count; j++)
            {
                if (ds[i] + ds[j] == x)
                {
                    List<int> pair = new List<int> { ds[i], ds[j] };
                    pairs.Add(pair);
                }
            }
        }

        return pairs;
    }


    static int TongChuSo(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    static int TongChuSoMax(List<int> ds)  //2.7
    {
        int max = int.MinValue, res = 0;

        foreach (int i in ds)
        {
            if (TongChuSo(i) > max)
                max = i;
            res = i;
        }
        return res;
    }


    static int TimGiaTriLonNhat(List<int> ds)
    {
        if (ds.IndexOf(TimMax(ds)) < ds.Count - 1)
        {
            return TimMax(ds);
        }
        return -1;
    }

    static List<List<int>> TimCapCoHieuNT(List<int> ds, int x)    //2.9
    {
        List<List<int>> pairs = new List<List<int>>();
        for (int i = 0; i < ds.Count; i++)
        {
            for (int j = i + 1; j < ds.Count; j++)
            {
                List<int> temp = new List<int>() { ds[i] - ds[j], ds[j] - ds[i] };
                if (KiemTraNT(temp.Max()))
                {
                    List<int> pair = new List<int> { ds[i], ds[j] };
                    pairs.Add(pair);
                }
            }
        }

        return pairs;
    }

    //static void XoaPhanTuDauTienLonHonX(List<int> ds, int x)
    //{
    //    int indexToRemove = -1;
    //    for (int i = 0; i < ds.Count; i++)
    //    {
    //        if (ds[i] > x)
    //        {
    //            indexToRemove = i; 
    //            break;
    //        }
    //    }

    //    if (indexToRemove != -1)
    //    {
    //        for (int i = indexToRemove; i < ds.Count - 1; i++)
    //        {
    //            ds[i] = ds[i + 1];
    //        }

    //        ds.RemoveAt(ds.Count - 1);
    //    }
    //}
    static void XoaPhanTuDauTienLonHonX(List<int> ds, int x) //2.10
    {
        foreach (int i in ds)
        {
            if (i > x)
            {
                ds.Remove(i);
                break;
            }
        }
    }


    //static void ChenXMangTang(List<int> ds, int x)
    //{
    //    SapXepTangDan(ds);
    //    int index = ds.Count;
    //    for (int i = 0; i < ds.Count - 1; i++)
    //    {
    //        if (ds[i] <= x && ds[i + 1] >= x)
    //        {
    //            index = i + 1;
    //            break;
    //        }
    //    }
    //    ds.Add(0);
    //    for (int i = ds.Count - 2; i >= index; i--)
    //    {
    //        ds[i + 1] = ds[i];
    //    }

    //    ds[index] = x;
    //}
    static void ChenXMangTang(List<int> ds, int x)  //2.11
    {
        SapXepTangDan(ds);
        for (int i = 0; i < ds.Count - 1; i++)
            if (ds[i] <= x && ds[i + 1] >= x)
            {
                ds.Insert(i + 1, x);
            }
    }

    //static void ChenXDauMang(List<int> ds, int x)
    //{
    //    ds.Add(0);
    //    for(int i = ds.Count()-2; i > -1; i--)
    //    {
    //        ds[i+1] = ds[i];
    //    }
    //    ds[0] = x;
    //}



    static void ChenXDauMang(List<int> ds, int x) //2.12
    {
        ds.Insert(0, x);
    }


    //static void XoaPhanTuLonHonX(List<int> ds, int x)
    //{
    //    List<int> newList = new List<int>();

    //    foreach (int i in ds)
    //    {
    //        if (i <= x)
    //        {
    //            newList.Add(i);
    //        }
    //    }
    //    ds.Clear();
    //    ds.AddRange(newList);
    //}

    static void XoaPhanTuLonHonX(List<int> ds, int x) //2.13
    {
        foreach (int i in ds)
        {
            if (i > x)
            {
                ds.Remove(i);
            }
        }
    }

    static void XoaNT(List<int> ds)  //2.14
    {
        foreach (int i in ds)
        {
            if (KiemTraNT(i))
                ds.Remove(i);
        }
    }

    static int TimViTriMaxDauTien(List<int> ds)   //2.15
    {
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i] == ds.Max())
                return i + 1;
        }
        return -1;
    }
    static int TimViTriMinCuoiCung(List<int> ds)   //2.16
    {
        for (int i = ds.Count - 1; i > -1; i--)
        {
            if (ds[i] == ds.Min())
                return i + 1;
        }
        return -1;
    }

    static int DemLonHonTruocNo(List<int> ds, int x)  //2.17
    {
        int count = 0;
        for (int i = ds.IndexOf(x); i > -1; i--)
        {
            if (ds[i] > x)
                count++;
        }
        return count;
    }

    static int DemNhoHonSauNo(List<int> ds, int x)  //2.18
    {
        int count = 0;
        for (int i = ds.IndexOf(x); i < ds.Count; i++)
        {
            if (ds[i] < x)
                count--;
        }
        return count;
    }

    static int TimPhanTuNhoNhatKhongAm(List<int> ds)   //2.19
    {
        int res = int.MaxValue;
        foreach (int i in ds)
            if (i < res && i > 0)
                res = i;
        return res;
    }

    static int DemSoLanHoanDoiSapXepMang(List<int> ds)    //2.20
    {
        int n = ds.Count;
        bool[] visited = new bool[n];
        (int value, int index)[] indexedArr = new (int, int)[n];

        for (int i = 0; i < n; i++)
        {
            indexedArr[i] = (ds[i], i);
        }

        Array.Sort(indexedArr, (a, b) => a.value.CompareTo(b.value));

        int swaps = 0;
        for (int i = 0; i < n; i++)
        {
            if (visited[i] || indexedArr[i].index == i)
                continue;

            int cycleSize = 0;
            int j = i;
            while (!visited[j])
            {
                visited[j] = true;
                j = indexedArr[j].index;
                cycleSize++;
            }

            if (cycleSize > 1)
                swaps += (cycleSize - 1);
        }

        return swaps;
    }

    static int DemSoLanXuatHien(List<int> ds, int x)
    {
        int count = 0;
        foreach (int i in ds)
            if (i == x)
                count++;
        return count;
    }
    static int TimSoLanXuatHienLonNhat(List<int> ds)
    {
        int max = int.MinValue;
        foreach (int i in ds)
        {
            if (max < DemSoLanXuatHien(ds, i))
                max = DemSoLanXuatHien(ds, i);
        }
        return max;
    }

    static int TimPhanTuXuatHienNhieuNhat(List<int> ds)    //2.21
    {
        int max = TimSoLanXuatHienLonNhat(ds);
        foreach (int i in ds)
        {
            if (DemSoLanXuatHien(ds, i) == max)
                return i;
        }
        return -1;
    }

    //static int TimPhanTuXuatHienNhieuNhat(List<int> ds)
    //{
    //    Dictionary<int, int> frequency = new Dictionary<int, int>();
    //    int maxCount = 0, maxElement = ds[0];

    //    foreach (int num in ds)
    //    {
    //        if (frequency.ContainsKey(num))
    //            frequency[num]++;
    //        else
    //            frequency[num] = 1;

    //        if (frequency[num] > maxCount)
    //        {
    //            maxCount = frequency[num];
    //            maxElement = num;
    //        }
    //    }

    //    return maxElement;
    //}

    //static void XoaPhanTuTaiK(List<int> ds, int k)
    //{
    //    for(int i = k; i < ds.Count - 1; i++)
    //    {
    //        ds[i] = ds[i + 1];
    //    }
    //}

    static void XoaPhanTuTaiK(List<int> ds, int k) //2.23
    {
        ds.Remove(ds[k]);
    }

    static List<(int, int)> TimCacSoChanLienTiepCoHieuD(List<int> ds, int d)   //2.24
    {
        List<(int, int)> res = new List<(int, int)>();

        for (int i = 0; i < ds.Count - 1; i++)
        {
            if (ds[i] % 2 == 0 && ds[i + 1] % 2 == 0 && Math.Abs(ds[i] - ds[i + 1]) == d)
            {
                res.Add((ds[i], ds[i + 1]));
            }
        }
        if (Math.Abs(ds[ds.Count - 1] - ds[0]) == d)
            res.Add((ds[ds.Count - 1], ds[0]));

        return res;
    }

    static bool KiemTraPhanTuChung(List<int> ds, List<int> ds2)   //2.26
    {
        foreach (int i in ds)
        {
            if (ds2.IndexOf(i) != -1)
                return true;
        }
        return false;
    }

    static (List<int>, List<int>) TachMangConChanLe(List<int> ds)   //2.27
    {
        List<int> chan = new List<int>();
        List<int> le = new List<int>();
        foreach (int i in ds)
        {
            if (i % 2 != 0) le.Add(i);
            else chan.Add(i + 1);
        }
        return (chan, le);
    }

    static bool KiemTraMangSapXep(List<int> ds)   //2.28
    {
        bool ascen = true;
        bool descen = true;
        for (int i = 0; i < ds.Count - 1; i++)
        {
            if (ds[i] > ds[i + 1])
                ascen = false;
            if (ds[i] > ds[i + 1])
                descen = false;
        }
        return ascen || descen;
    }

    static int TimSoChanLonHonSoChoTruoc(List<int> ds, int n)    //2.29
    {
        List<int> chan = TimChan(ds);
        SapXepTangDan(chan);
        foreach (int i in chan)
            if (i > n) return i;
        return -1;
    }

    static int TimPhanTuItNhat(int[] arr)  //2.30
    {
        Dictionary<int, int> tanSuat = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (tanSuat.ContainsKey(num))
                tanSuat[num]++;
            else
                tanSuat[num] = 1;
        }

        int minSoLan = int.MaxValue;
        int ketQua = arr[0];

        foreach (var kvp in tanSuat)
        {
            if (kvp.Value < minSoLan)
            {
                minSoLan = kvp.Value;
                ketQua = kvp.Key;
            }
        }

        return ketQua;
    }

    static List<int> DaoNguocDanhSach(List<int> ds)    //3.1
    {
        List<int> res = new List<int>();
        for (int i = ds.Count - 1; i >= 0; i--)
            res.Add(ds[i]);
        return res;
    }

    static void DaoNguocThuTu(List<int> ds)   //3.1
    {
        ds.Reverse();
    }

    static List<int> XoaPhanTuTrung(List<int> ds)  //3.2
    {
        List<int> res = new List<int>();
        foreach (int i in ds)
        {
            if (res.IndexOf(i) == -1)
                res.Add(i);
        }
        return res;
    }

    //static List<int> XoaPhanTuTrung(List<int> ds)          3.2
    //{
    //    HashSet<int> seen = new HashSet<int>();
    //    List<int> res = new List<int>();

    //    foreach (int i in ds)
    //    {
    //        if (seen.Add(i))
    //            res.Add(i);
    //    }

    //    return res;
    //}






    static List<int> TaoMangChiaHetCho3(List<int> ds)    //3.3
    {
        List<int> res = new List<int>();
        foreach (int i in ds)
        {
            if (i % 3 == 0)
                res.Add(i);
        }
        return res;
    }

    static int TinhTongLonNhatDayConLienTiep(List<int> ds)    //3.4   -  Thuật toán Kadane
    {
        int current_max = ds[0];
        int global_max = ds[0];

        for (int i = 1; i < ds.Count; i++)
        {
            current_max = Math.Max(ds[i], current_max + ds[i]);
            global_max = Math.Max(global_max, current_max);
        }

        return global_max;
    }

    static int DemDayConCoTongS(List<int> ds, int S)     //3.5    -     Thuật toán Prefixsum
    {
        Dictionary<int, int> prefixSumCounts = new Dictionary<int, int>();
        int count = 0, prefixSum = 0;

        prefixSumCounts[0] = 1;

        foreach (int num in ds)
        {
            prefixSum += num;

            if (prefixSumCounts.ContainsKey(prefixSum - S))
                count += prefixSumCounts[prefixSum - S];

            if (!prefixSumCounts.ContainsKey(prefixSum))
                prefixSumCounts[prefixSum] = 0;

            prefixSumCounts[prefixSum]++;
        }

        return count;
    }


    //static bool KiemTraTonTai3PhanTuLienTiepTongX(List<int> ds, int x)   3.6
    //{
    //    if (ds.Count < 3) return false;
    //    for (int i = 0; i < ds.Count-2; i++) 
    //        if (ds[i] + ds[i+1] + ds[i+2] == x)
    //            return true;
    //    return false;
    //}

    static bool KiemTraTonTai3PhanTuLienTiepTongX(List<int> ds, int x)   //3.6   -     Thuật toán Cửa sổ trượt (window sliding)
    {
        if (ds.Count < 3) return false;

        int sum = ds[0] + ds[1] + ds[2];
        if (sum == x) return true;

        for (int i = 3; i < ds.Count; i++)
        {
            sum = sum - ds[i - 3] + ds[i];
            if (sum == x) return true;
        }

        return false;
    }

    static List<int> DemSoLanXuatHienCuaTungPhanTu(List<int> ds)    //3.7
    {
        List<int> list = new List<int>();
        foreach (int i in ds)
            if (list[i] == 0)
                list[i] = DemSoLanXuatHien(ds, i);
        return list;
    }

    static List<List<int>> TimDayConCoTongNguyenTo(List<int> ds)    //3.8
    {
        int n = ds.Count;
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            List<int> sublist = new List<int>();

            for (int j = i; j < n; j++)
            {
                sum += ds[j];
                sublist.Add(ds[j]);

                if (KiemTraNT(sum))
                {
                    result.Add(new List<int>(sublist));
                }
            }
        }
        return result;
    }

    //static List<int> TimDayConToanChanDaiNhat(List<int> ds)    3.9
    //{
    //    List<int> res = new List<int>();
    //    foreach(int i in ds)
    //        if(i % 2 == 0 && res.IndexOf(i) == -1)
    //            res.Add(i);
    //    return res;
    //}


    static List<int> TimDayConToanChanDaiNhat(List<int> ds)   //3.9
    {
        HashSet<int> set = new HashSet<int>(); 
        List<int> res = new List<int>();

        foreach (int i in ds)
        {
            if (i % 2 == 0 && set.Add(i))
            {
                res.Add(i);
            }
        }

        return res;
    }

    //static int TimDoDaiDayConTangDaiNhat(List<int> ds)   3.10      -      Dynamic Programming (Quy hoạch động)
    //{
    //    if (ds == null || ds.Count == 0)
    //        return 0;


    //    List<int> res = new List<int>(new int[ds.Count]);
    //    for (int i = 0; i < ds.Count; i++)
    //        res[i] = 1;

    //    for (int i = ds.Count - 2; i >= 0; i--)
    //    {
    //        for (int j = i + 1; j < ds.Count; j++)
    //        {
    //            if (ds[i] < ds[j])
    //            {
    //                res[i] = Math.Max(res[i], 1 + res[j]);
    //            }
    //        }
    //    }
    //    return res.Max();
    //}



    static int TimDoDaiDayConTangDaiNhat(List<int> ds)     //3.10      -      Dynamic Prgrogramming + Binary Search
    {
        if (ds == null || ds.Count == 0)
            return 0;

        List<int> dp = new List<int>();
        dp.Add(ds[0]);

        for (int i = 1; i < ds.Count; i++)
        {
            if (ds[i] > dp[dp.Count - 1])
            {
                dp.Add(ds[i]);
            }
            else
            {

                int left = 0;
                int right = dp.Count - 1;

                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (dp[mid] >= ds[i])
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                dp[left] = ds[i];
            }
        }
        return dp.Count;
    }

    //static int TimDoDaiDayConGiamDaiNhat(List<int> ds)   3.10      -      Dynamic Programming (Quy hoạch động)
    //{
    //    if (ds == null || ds.Count == 0)
    //        return 0;


    //    List<int> res = new List<int>(new int[ds.Count]);
    //    for (int i = 0; i < ds.Count; i++)
    //        res[i] = 1;
    //    for (int i = ds.Count - 2; i >= 0; i--)
    //    {
    //        for (int j = i + 1; j < ds.Count; j++)
    //        {
    //            if (ds[i] > ds[j])
    //            {
    //                res[i] = Math.Max(res[i], 1 + res[j]);
    //            }
    //        }
    //    }
    //    return res.Max();
    //}

    static int TimDoDaiDayConGiamDaiNhat(List<int> ds) //3.11      -      Dynamic Prgrogramming + Binary Search   
    {
        if (ds == null || ds.Count == 0)
            return 0;

        List<int> dp = new List<int>();
        dp.Add(ds[0]);

        for (int i = 1; i < ds.Count; i++)
        {
            if (ds[i] < dp[dp.Count - 1])
            {
                dp.Add(ds[i]);
            }
            else
            {
                int left = 0;
                int right = dp.Count - 1;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (dp[mid] <= ds[i])
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                dp[left] = ds[i];
            }
        }

        return dp.Count;
    }

    static int DemSoLanXXuatHienLienTiep(List<int> ds, int x)     //3.12
    {
        int count = 0;
        int maxCount = 0;
        for(int i = 0; i < ds.Count-1; i++)
        {
            if (ds[i] == x)
            {
                count++;
                maxCount = Math.Max(maxCount, count);
            }
            else
            {
                count = 0;
            }
        }

        return maxCount;
    }

    //static int TimViTriXuatHienCuaXTrongMang(List<int> ds, int x)     3.13
    //{
    //    for (int i = ds.Count - 1; i >= 0; i--)
    //        if (ds[i] == x)
    //            return i + 1;
    //    return -1;
    //}


    static int TimViTriXuatHienCuaXTrongMang(List<int> ds, int x)    //3.13
    {
        int index = ds.LastIndexOf(x);
        return index == -1 ? -1 : index + 1;
    }




}