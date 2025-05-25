using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap3
{
    internal class DanhSachPhuongTien
    {
        public List<IVehicle> Vehicles;

        public DanhSachPhuongTien() 
        {
            Vehicles = new List<IVehicle>();
        }

        public void XuatDanhSachPhuongTien()
        {
            foreach (IVehicle vehicle in Vehicles)
                Console.WriteLine(vehicle);
        }

        public enum Properties
        {
            flyable, floatable, drivable, divable
        }

        //public Properties GetPType(IVehicle vh)
        //{
        //    if (vh is Car)
        //        return Properties.drivable;
        //    else if (vh is Boat)
        //        return Properties.floatable;
        //    else if (vh is AquaPlane)
        //        return Properties.floatable;
        //}

        public List<IVehicle> TimKiemPhuongTien(Properties prop)
        {
            List<IVehicle> res = new List<IVehicle>();
            foreach(var i in Vehicles)
            {
                if(prop == Properties.flyable)
                    if(i is AquaPlane)
                        res.Add((AquaPlane)i);
                else if (prop == Properties.drivable)
                    if(i is Car)
                        res.Add((Car)i);
                else if (prop == Properties.divable)
                    if(i is SubMarine)
                        res.Add((SubMarine)i);
                else if (prop == Properties.floatable)
                    if(i is AquaPlane && i is SubMarine)
                        res.Add(i);
            }
            return res;
        }


    }
}
