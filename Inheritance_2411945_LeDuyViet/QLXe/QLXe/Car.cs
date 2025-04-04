using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    internal class Car : Vehicle
    {
        public Car() { }
        public Car(string name, int speed) : base(name,speed)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Xe hoi dang di chuyen");
        }

        public override void Stop()
        {
            Console.WriteLine("Xe hoi dang dung...");
        }
    }
}
