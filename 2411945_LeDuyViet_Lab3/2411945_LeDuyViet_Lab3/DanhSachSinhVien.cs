using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace _2411945_LeDuyViet_Lab3
{
    internal class DanhSachSinhVien
    {
        List<SinhVien> ds = new List<SinhVien>();

        public void Them(SinhVien sv) => ds.Add(sv);

        public void NhapTuFile()
        {
            using StreamReader sr = new StreamReader("data.txt");
            string line;
            while ((line = sr.ReadLine()) != null) 
                Them(new SinhVien(line));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("MSSV Ho ten      DTB Gioi Tinh Lop\n");
            foreach (var sv in ds) sb.Append(sv + "\n");
            return sb.ToString();
        }

        public float TimDTBCaoNhat() => ds.Max(x => x.dTB);

        public DanhSachSinhVien TimDSSVCoDTBCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            float max = TimDTBCaoNhat();
            foreach (var sv in ds) 
                if (sv.dTB == max) 
                    kq.Them(sv);
            return kq;
        }

        public List<string> LayDanhSachLop()
        {
            List<string> kq = new List<string>();
            foreach (var sv in ds) 
                if (!kq.Contains(sv.Lop)) 
                    kq.Add(sv.Lop);
            return kq;
        }

        public string TimLopTheoTongDTB(bool timCaoNhat)
        {
            List<string> dsLop = LayDanhSachLop();
            float[] tongDTB = new float[dsLop.Count];

            for (int i = 0; i < ds.Count; i++)
                tongDTB[dsLop.IndexOf(ds[i].Lop)] += ds[i].dTB;

            return dsLop[Array.IndexOf(tongDTB, timCaoNhat ? tongDTB.Max() : tongDTB.Min())];
        }

        public string TimLopCoTongDTBCaoNhat() => TimLopTheoTongDTB(true);
        public string TimLopCoTongDTBThapNhat() => TimLopTheoTongDTB(false);

        public string TimLopTheoHSG(bool timNhieuHSG)
        {
            List<string> dsLop = LayDanhSachLop();
            int[] soLuongHSG = new int[dsLop.Count];

            for (int i = 0; i < ds.Count; i++)
                if (ds[i].dTB >= 8.0) 
                    soLuongHSG[dsLop.IndexOf(ds[i].Lop)]++;

            return dsLop[Array.IndexOf(soLuongHSG, timNhieuHSG ? soLuongHSG.Max() : soLuongHSG.Min())];
        }

        public string TimLopCoNhieuHSGNhat() => TimLopTheoHSG(true);
        public string TimLopCoItHSGNhat() => TimLopTheoHSG(false);

        public List<string> TimLopKhongCoGioiTinh(bool timLopKhongCoNu)
        {
            List<string> dsLop = LayDanhSachLop();
            List<string> lopCoGioiTinh = new List<string>();

            for (int i = 0; i < ds.Count; i++)
                if ((timLopKhongCoNu && !ds[i].gioiTinh) || (!timLopKhongCoNu && ds[i].gioiTinh))
                    if (!lopCoGioiTinh.Contains(ds[i].Lop)) 
                        lopCoGioiTinh.Add(ds[i].Lop);

            List<string> lopKhongCoGT = new List<string>();
            foreach (var lop in dsLop) 
                if (!lopCoGioiTinh.Contains(lop)) 
                    lopKhongCoGT.Add(lop);

            return lopKhongCoGT;
        }

        public List<string> TimLopKhongCoNu() => TimLopKhongCoGioiTinh(true);
        public List<string> TimLopKhongCoNam() => TimLopKhongCoGioiTinh(false);

        public int TimViThuCuaSV(SinhVien sv)
        {
            int vt = 1;
            foreach (var i in ds) 
                if (sv.Lop == i.Lop && sv.dTB < i.dTB) 
                    vt++;
            return vt;
        }

        public void XuatDanhSachSinhVien()
        {
            using StreamWriter sw = new StreamWriter("result.txt");
            foreach (var i in ds) 
                sw.WriteLine(i);
        }

        public enum KieuSapXep 
        { 
            TangDTB, 
            GiamDTB 
        }
        

        void SapXep(KieuSapXep kieu)
        {
            ds.Sort((sv1, sv2) => kieu == KieuSapXep.TangDTB ? sv1.dTB.CompareTo(sv2.dTB) : sv2.dTB.CompareTo(sv1.dTB));
        }

        public void SapXepTangTheoDTB() => SapXep(KieuSapXep.TangDTB);
        public void SapXepGiamTheoDTB() => SapXep(KieuSapXep.GiamDTB);
        public int DemSoLuongSVTheoLop(string lop) => ds.Count(sv => sv.Lop == lop);

        void XoaSinhVienTheoLop(string lop) => ds.RemoveAll(sv => sv.Lop == lop);

        public string XepLoaiSinhVien(SinhVien sv)
        {
            return sv.dTB >= 8.0 ? "Giỏi" :
                   sv.dTB >= 6.5 ? "Khá" :
                   sv.dTB >= 5.0 ? "Trung bình" : "Yếu";
        }

        public void HienThiDanhSachXepLoai()
        {
            Console.WriteLine("MSSV    Họ Tên       ĐTB   Xếp Loại");
            foreach (var sv in ds)
                Console.WriteLine($"{sv.maSV,-6} {sv.hoTen,-12} {sv.dTB,-4} {XepLoaiSinhVien(sv)}");
        }


    }

}

