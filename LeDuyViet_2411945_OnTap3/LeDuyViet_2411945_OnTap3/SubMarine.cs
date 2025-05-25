using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap3
{
    internal class SubMarine : Vehicle, IDive, IFloat
    {
        public SubMarine() { }
        public SubMarine(string name, string manufacturer, int year) : base(name, manufacturer, year) { }
        public void Dive()
        {
            Console.WriteLine("Dang lan...");
        }

        public void Float()
        {
            Console.WriteLine("Dang noi...");
        }
    }
}
