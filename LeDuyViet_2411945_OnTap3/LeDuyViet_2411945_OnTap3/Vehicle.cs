using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap3
{
    internal class Vehicle : IVehicle
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }

        protected Vehicle(string name, string manufacturer, int year)
        {
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
        }
        public override string ToString()
        {
            return string.Format("{0,10} {1,10} {2,5}",Name,Manufacturer,Year);
        }
    }
}
