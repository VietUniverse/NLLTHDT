using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap3
{
    internal class Boat : Vehicle, IFloat
    {
        public Boat() { }
        public Boat(string name, string manufacturer, int year) : base(name, manufacturer, year) { }
        public void Float()
        {
            Console.WriteLine("Dang noi...");
        }
    }
}
