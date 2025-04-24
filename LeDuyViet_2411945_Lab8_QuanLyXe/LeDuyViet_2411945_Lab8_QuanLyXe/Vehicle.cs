    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab8_QuanLyXe
{
    internal class Vehicle : IVehicle
    {
        public string Name { get ; set ; }
        public int TocDo { get ; set ; }

        public Vehicle() { }

        public Vehicle(string name, int tocDo)
        {
            Name = name;
            TocDo = tocDo;
        }

        public void Chay()
        {

        }

        public void Dung()
        {

        }

        public override string ToString()
        {
            return string.Format("{0, 5} {1, 5}", Name, TocDo);
        }
    }
}
