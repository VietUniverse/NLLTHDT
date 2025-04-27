using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        public void ThemThuCong(string s)
        {
            IVehicle v = new Vehicle();
            var line = s.Split(',');
            var ten = line[0].Trim();
            var tocDo = int.Parse(line[1].Trim());
            if (line[0] == "Car")
            {
                var scn = int.Parse(line[3].Trim());
                v = new Car(ten, tocDo, scn);
            }
            else
            {
                v = new Motorcycle(ten, tocDo);
            }
            Them(v);
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
            IVehicle v = new Vehicle();
            while ((s = sr.ReadLine()) != null)
            {
                var line = s.Split(',');
                var ten = line[0].Trim();
                var tocDo = int.Parse(line[1].Trim());
                if (line[0] == "Car")
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

        public int TimPhuongTienTheoTen(string name)
        {
            for(int i = 0; i < vehicles.Count; i++)
            {
                if(vehicles[i].Name == name)
                    return i;
            }
            return -1;
        }

        public int TimPhuongTienTheoTocDo(int pace)
        {
            for(int i = 0;i < vehicles.Count; i++)
                if (vehicles[i].TocDo == pace)
                    return i;
            return -1;
        }
        
        public int TimPhuongTienTheoSoChoNgoi(int scn)
        {
            for (int i = 0;i < vehicles.Count ; i++)
                if (((ICar)vehicles[i]).SoChoNgoi == scn)
                    return i;
            return -1;
        }

        public int TimPhuongTienTheoTenTocDo(string name, int pace)
        {
            for(int i =0;i < vehicles.Count;i++)
                if(vehicles[i].Name == name && vehicles[i].TocDo == pace)
                    return i;
            return -1;
        }
        public int TimPhuongTienTheoTenSCN(string name, int scn)
        {
            for (int i = 0; i < vehicles.Count; i++)
                if (vehicles[i].Name == name && ((ICar)vehicles[i]).SoChoNgoi == scn)
                    return i;
            return -1;
        }
        public int TimPhuongTienTheoTocDoSCN(int pace, int scn)
        {
            for (int i = 0; i < vehicles.Count; i++)
                if (vehicles[i].TocDo == pace && ((ICar)vehicles[i]).SoChoNgoi == scn)
                    return i;
            return -1;
        }

        public int TimTocDoLonNhat()
        {
            int max = 0;
            for(int i =0; i < vehicles.Count;i++)
                if (vehicles[i].TocDo > max)
                    max = vehicles[i].TocDo;
            return max;
        }

        public int TimPhuongTienCoTocDoLonNhat()
        {
            for(int i = 0;i < vehicles.Count;i++)
                if (vehicles[i].TocDo == TimTocDoLonNhat())
                    return i;
            return -1;
        }

        public int TimSoChoNgoiLonNhat()
        {
            int max = 0;
            for(int i =0;i < vehicles.Count;i++)
                if (((ICar)vehicles[i]).SoChoNgoi > max)
                    max = ((ICar)vehicles[i]).SoChoNgoi;
            return max;
        }

        public int TimPhuongTienCoSoChoNgoiLonNhat()
        {
            for (int i = 0; i < vehicles.Count; i++)
                if (((ICar)vehicles[i]).SoChoNgoi == TimSoChoNgoiLonNhat())
                    return i;
            return -1;
        }

        public int TimTocDoNhoNhat()
        {
            int min = int.MaxValue;
            for (int i = 0; i < vehicles.Count; i++)
                if (vehicles[i].TocDo < min)
                    min = vehicles[i].TocDo;
            return min;
        }

        public int TimPhuongTienCoTocDoNhoNhat()
        {
            for (int i = 0; i < vehicles.Count; i++)
                if (vehicles[i].TocDo == TimTocDoNhoNhat())
                    return i;
            return -1;
        }

        public int TimSoChoNgoiNhoNhat()
        {
            int min = int.MaxValue;
            for (int i = 0; i < vehicles.Count; i++)
                if (((ICar)vehicles[i]).SoChoNgoi < min)
                    min = ((ICar)vehicles[i]).SoChoNgoi;
            return min;
        }

        public int TimPhuongTienCoSoChoNgoiNhoNhat()
        {
            for (int i = 0; i < vehicles.Count; i++)
                if (((ICar)vehicles[i]).SoChoNgoi == TimSoChoNgoiNhoNhat())
                    return i;
            return -1;
        }

        public enum SapXep
        {
            tang,giam
        }
        void SwapItem(int i, int j)
        {
            IVehicle vehicle3 = vehicles[i];
            vehicles[i] = vehicles[j];
            vehicles[j] = vehicle3;
        }
        public void SapXepTheoTen(SapXep sx)
        {
            for (int i = 0;i < vehicles.Count-1;i++)
                for(int j = i+1; j < vehicles.Count;j++)
                    if (string.Compare(vehicles[i].Name, vehicles[j].Name) < 0 && sx == SapXep.giam)
                        SwapItem(i, j);
                    else if(string.Compare(vehicles[i].Name, vehicles[j].Name) > 0 && sx == SapXep.tang)
                        SwapItem(i, j);
        }
        public void SapXepTheoTocDo(SapXep sx)
        {
            for (int i = 0; i < vehicles.Count - 1; i++)
                for (int j = i + 1; j < vehicles.Count; j++)
                    if (vehicles[i].TocDo < vehicles[j].TocDo && sx == SapXep.giam)
                        SwapItem(i, j);
                    else if (vehicles[i].TocDo > vehicles[j].TocDo && sx == SapXep.tang)
                        SwapItem(i, j);
        }

        public void SapXepTheoSoChoNgoi(SapXep sx)
        {
            for (int i = 0; i < vehicles.Count - 1; i++)
                for (int j = i + 1; j < vehicles.Count; j++)
                    if (GetVType(vehicles[i]) == VType.car && GetVType(vehicles[j]) == VType.car)
                    {
                        if (((ICar)vehicles[i]).SoChoNgoi < ((ICar)vehicles[j]).SoChoNgoi && sx == SapXep.giam)
                            SwapItem(i, j);
                        else if (vehicles[i].TocDo > vehicles[j].TocDo && sx == SapXep.tang)
                            SwapItem(i, j);
                    }
                    else if(GetVType(vehicles[i]) == VType.motorcycle || GetVType(vehicles[j]) == VType.motorcycle)
                    {
                        if (GetVType(vehicles[i]) == VType.motorcycle && sx == SapXep.giam)
                            SwapItem(i, j);
                        else if (GetVType(vehicles[j]) == VType.motorcycle && sx == SapXep.tang)
                            SwapItem(i, j);
                    }
        }
    }
}
