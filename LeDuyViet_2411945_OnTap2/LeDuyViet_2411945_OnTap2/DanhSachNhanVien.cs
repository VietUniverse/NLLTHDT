using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap2
{
    internal class DanhSachNhanVien
    {
        public List<INhanVien> employees;
        public DanhSachNhanVien()
        {
            employees = new List<INhanVien>();
        }

        public void ThemThuCong(string ho, string ten, int id, string phong, float luong)
        {
            INhanVien nv = new QuanLy(ho, ten, id, phong, luong);
            employees.Add(nv);
        }

        public void DocTuFile()
        {
            using(StreamReader sr = new StreamReader("data.txt"))
            {
                string s;
                string[] line;

                while ((s = sr.ReadLine()) != null)
                {
                    line = s.Split(",");
                    ThemThuCong(line[0], line[1], int.Parse(line[2]), line[3], float.Parse(line[4]));
                }
            }
        }

        public void XuatRaFile()
        {
            using(StreamWriter sw = new StreamWriter("result.txt"))
            {
                foreach(var i in employees)
                {
                    sw.WriteLine(i.LayThongTinChiTiet());
                }
            }
        }
        public void Xuat(INhanVien nv)
        {
            Console.WriteLine((QuanLy)nv);
        }

        public void XuatDanhSachNhanVien()
        {
            foreach (var i in employees)
                Xuat(i);
        }

        public List<int> TimKiemTheoTen(string ten)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < employees.Count; i++)
            {
                if (((QuanLy)employees[i]).Ten == ten)
                    list.Add(i);
            }
            return list;
        }

        public List<int> TimKiemTheoHoTen(string ho, string ten)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (((QuanLy)employees[i]).Ten == ten && ((QuanLy)employees[i]).Ho == ho)
                    list.Add(i);
            }
            return list;
        }
        public List<int> TimKiemTheoPhong(string phong)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (((QuanLy)employees[i]).Phong == phong)
                    list.Add(i);
            }
            return list;
        }

        public int TimKiemTheoID(int id)
        {
            for(int i = 0;i < employees.Count;i++) 
            {
                if (((QuanLy)employees[i]).NhanVienID == id)
                    return i;
            }
            return -1;
        }

        public enum SapXep
        {
            tang,giam
        }

        void SwapItem(int x, int y)
        {
            INhanVien nhanvien = employees[x];
            employees[x] = employees[y];
            employees[y] = nhanvien;
        }

        public void SapXepTheoTen(SapXep sx)
        {
            for(int i = 0; i < employees.Count-1; i++)
            {
                for(int j = 0; j < employees.Count; j++)
                {
                    if(sx == SapXep.tang && string.Compare(((QuanLy)employees[i]).Ten, ((QuanLy)employees[j]).Ten) > 0)
                        SwapItem(i, j);
                    else if(sx == SapXep.giam && string.Compare(((QuanLy)employees[i]).Ten, ((QuanLy)employees[j]).Ten) < 0)
                        SwapItem(i,j);
                }
            }
        }

        public void SapXepTheoPhong(SapXep sx)
        {
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = 0; j < employees.Count; j++)
                {
                    if (sx == SapXep.tang && string.Compare(((QuanLy)employees[i]).Phong, ((QuanLy)employees[j]).Phong) > 0)
                        SwapItem(i, j);
                    else if (sx == SapXep.giam && string.Compare(((QuanLy)employees[i]).Phong, ((QuanLy)employees[j]).Phong) < 0)
                        SwapItem(i, j);
                }
            }
        }

        public void SapXepTheoID(SapXep sx)
        {
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = 0; j < employees.Count; j++)
                {
                    if (sx == SapXep.tang && ((QuanLy)employees[i]).NhanVienID > ((QuanLy)employees[j]).NhanVienID)
                        SwapItem(i, j);
                    else if (sx == SapXep.giam && ((QuanLy)employees[i]).NhanVienID < ((QuanLy)employees[j]).NhanVienID)
                        SwapItem(i, j);
                }
            }
        }

        public enum nhanvien
        {
            ho,ten,id,phong
        }

        public void SuaThongTin(int vt, nhanvien nv, string data)
        {
            if (nv == nhanvien.ho)
                ((QuanLy)employees[vt]).Ho = data;
            else if (nv == nhanvien.ten)
                ((QuanLy)employees[vt]).Ten = data;
            else if (nv == nhanvien.id)
                ((QuanLy)employees[vt]).NhanVienID = int.Parse(data);
            else
                ((QuanLy)employees[vt]).Phong = data;
        }

        public void Xoa(int vt)
        {
            employees.RemoveAt(vt);
        }

        public void LocNhanVienThuocPhong(string phong)
        {
            List<int> ints = TimKiemTheoPhong(phong);
            foreach (int i in ints)
                Console.WriteLine(employees[i]);
        }

        public void LocNhanVienTheoTen(string ten)
        {
            List<int> ints = TimKiemTheoTen(ten);
            foreach (int i in ints)
                Console.WriteLine(employees[i]);
        }

        public float TinhTongLuong()
        {
            float sum = 0.0f;
            foreach (var i in employees)
                sum += i.Luong;
            return sum;
        }
    }
}
