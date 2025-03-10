﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2411945_LeDuyViet_Lab3
{
    internal class DanhSachSinhVien
    {
        //Định nghĩa danh sách gồm các đối tượng SinhVien
        List<SinhVien> ds = new List<SinhVien>();

        //Định nghĩa phương thức Them đối tượng SinhVien
        public void Them(SinhVien sv)
        {
            ds.Add(sv);
        }

        //Định nghĩa phương thức nhập từ file data.txt bằng StreamReader
        public void NhapTuFile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while ((line = sr.ReadLine()) != null) //Tiếp tục chạy khi line vẫn còn chuỗi
            {
                Them(new SinhVien(line));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MSSV".PadRight(6) + "Ho ten".PadRight(14) + "DTB".PadRight(2) + " Gioi Tinh" + "Lop \n".PadLeft(10));
            foreach (var sv in ds)
            {
                sb.Append(sv + "\n");
            }
            return sb.ToString();
        }
        public float TimDTBCaoNhat()
        {
            return ds.Min(x => x.dTB);
        }

        public DanhSachSinhVien TimDSSVCoDTBCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            float max = TimDTBCaoNhat();
            foreach (var item in ds)
            {
                if (item.dTB == max)
                {
                    kq.Them(item);
                }
            }
            return kq;
        }

        private int DemSoLuongSVTheoGioiTinhvalop(bool GT, string lop)
        {
            return ds.Count(x => x.gioiTinh == GT && x.Lop == lop);
        }

        public int DemSoLuongSVNam(string lop)
        {
            return DemSoLuongSVTheoGioiTinhvalop(true, lop);
        }

        public int DemSoLuongSVNu(string lop)
        {
            return DemSoLuongSVTheoGioiTinhvalop(false, lop);
        }
        public List<string> LayDanhSachLop()
        {
            List<string> kq = new List<string>();
            foreach (var sv in ds)
            {
                if (!kq.Contains(sv.Lop))
                {
                    kq.Add(sv.Lop);
                }
            }
            return kq;
        }

        public enum KieuSapXep
        {
            TangDTB,
            GiamDTB
        }

        void SapXep(KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangDTB)
            {
                ds.Sort((sv1, sv2) => sv1.dTB.CompareTo(sv2.dTB));
            }
            if (kieu == KieuSapXep.GiamDTB)
            {
                ds.Sort((sv1, sv2) => -sv1.dTB.CompareTo(sv2.dTB));
            }
        }

        public void SapXepTangTheoDTB()
        {
            SapXep(KieuSapXep.TangDTB);
        }

        public void SapXepGiamTheoDTB()
        {
            SapXep(KieuSapXep.GiamDTB);
        }
        public List<string> TimLopCoDTBCaoNhat()
        {
            List<string> lopDiemCao = new List<string>();
            float max = TimDTBCaoNhat();
            foreach (var i in ds)
            {
                if (i.dTB == max && !lopDiemCao.Contains(i.Lop))
                {
                    lopDiemCao.Add(i.Lop);
                }
            }
            return lopDiemCao;
        }

        public List<string> TimLopKhongCoDTBCaoNhat()
        {
            List<string> lopDiemCao = TimLopCoDTBCaoNhat();
            List<string> lopKoCao = new List<string>();
            foreach (var i in ds)
            {
                if (!lopDiemCao.Contains(i.Lop) && !lopKoCao.Contains(i.Lop))
                {
                    lopKoCao.Add(i.Lop);
                }
            }
            return lopKoCao;
        }

        public int TimViThuCuaSV(SinhVien sv)
        {
            int vt = 1;
            foreach (var i in ds)
            {
                if (sv.Lop == i.Lop && sv.dTB < i.dTB)
                {
                    vt++;
                }
            }
            return vt;
        }

        
    }
}
