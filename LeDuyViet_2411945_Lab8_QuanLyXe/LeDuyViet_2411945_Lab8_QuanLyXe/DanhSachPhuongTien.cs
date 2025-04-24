using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab8_QuanLyXe
{
    internal class DanhSachPhuongTien
    {
        public enum VType{
            car,
            motorcycle,
        }
        List<IVehicle> vehicles;

        public DanhSachPhuongTien()
        {
            vehicles = new List<IVehicle>();
        }

        public void Them(IVehicle pt)
        {
            vehicles.Add(pt);
        }

        public void Xuat()
        {
            foreach(var i in vehicles)
            {
                Console.WriteLine(i);
            }
        }

        public void ReadFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string s = "";
            IVehicle v;
            while ((s = sr.ReadLine()) != null)
            {
                var line = s.Split(',');
                var ten = line[0].Trim();
                var tocDo = int.Parse(line[1].Trim());
                if (line[0] == "C")
                {
                    var scn = int.Parse(line[3].Trim());
                    v = new Car(ten, tocDo, scn);
                }
                else
                {
                    v = new Motorcycle(ten, tocDo);
                }
            }
            Them(v);
        }

        //public int DemSoLuong(string type)
        //{
        //    int count = 0;
        //    foreach (var i in vehicles)
        //    {
        //        if (i.GetType().Name == type)
        //            count++;
        //    }
        //    return count;
        //}

        public VType GetVType(IVehicle vh)
        {
            if (vh is Motorcycle)
                return VType.motorcycle;
            return VType.car;
            
        }

        public int DemSoLuongTheoLoai(VType type)
        {
            int count = 0;
            foreach (var i in vehicles)
            {
                if (GetVType(i) == type)
                    count++;    
            }
            return count;
        }

        public int DemSoLuongTheoCar()
        {
            return DemSoLuongTheoLoai(VType.car);
        }

        public int DemSoLuongTheoMotocycle()
        {
            return DemSoLuongTheoLoai(VType.motorcycle);
        }

        public int DemSoLuongTheoCarHoacMotocycle(IVehicle pt)
        {
            return DemSoLuongTheoLoai(GetVType(pt));
        }

        public int DemSoLuongTheoCarVaMotorcycle()
        {
            return DemSoLuongTheoLoai(VType.motorcycle) + DemSoLuongTheoLoai(VType.car);
        }

        public int DemSoLuongTheoTen(string name)
        {
            int count = 0;
            foreach (var i in vehicles)
            {
                if (i.Name == name)
                    count++;
            }
            return count;
        }
        public int DemSoLuongTheoSCN(int scn)
        {
            int count = 0;
            foreach (var i in vehicles)
            {
                if (GetVType(i) == VType.car)
                    if (((Car)i).SoChoNgoi == scn)
                        count++;
            }
            return count;
        }

        public int DemSoLuongTheoTocDo(int pace)
        {
            int count = 0;
            foreach (var i in vehicles)
            {
                if(i.TocDo == pace)
                    count++;
            }
            return count;
        }

        public int DemSoLuongTheoTenTocDo(string name, int pace)
        {
            int count = 0;
            foreach (var i in vehicles)
            {
                if (i.TocDo == pace && i.Name == name)
                    count++;
            }
            return count;
        }
        public int DemSoLuongTheoTenTocDoSCN(string name, int pace, int scn)
        {
            int count = 0;
            foreach (var i in vehicles)
            {
                if(GetVType(i) == VType.car)
                    if (i.TocDo == pace && i.Name == name && (((Car)i).SoChoNgoi == scn))
                        count++;
            }
            return count;
        }
    }
}
