using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap3
{
    internal class AquaPlane : Vehicle, IFly, IFloat
    {
        public AquaPlane() { }
        public AquaPlane(string name, string manufacturer, int year) : base(name, manufacturer, year) { }
        public void Float()
        {
            Console.WriteLine("Dang noi...");
        }

        public void Fly()
        {
            Console.WriteLine("Dang bay...");
        }
    }
}
