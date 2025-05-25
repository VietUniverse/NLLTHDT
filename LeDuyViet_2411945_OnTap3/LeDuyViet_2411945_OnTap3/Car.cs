using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_OnTap3
{
    internal class Car : Vehicle, IDrive
    {
        public Car() { }
        public Car(string name, string manufacturer, int year) : base(name, manufacturer, year) { }
        public void Drive()
        {
            Console.WriteLine("Dang lai...");
        }
    }
}
