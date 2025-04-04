using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle() { }
        public Motorcycle(string name, float speed) : base(name, speed)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Xe may dang di chuyen");
        }

        public override void Stop()
        {
            Console.WriteLine("Xe may dang dung...");
        }
    }
}
