using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap3
{
    internal interface IVehicle
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }

        public float Speed { get; set; }
    }
}
