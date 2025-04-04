using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    public class Vehicle
    {
        public string Name { get; set; }
        public float Speed { get; set; }

        public Vehicle() { }
        public Vehicle(string name, float speed)
        {
            Name = name;
        }
        public virtual void Move()
        {
        }
        public virtual void Stop() 
        {
            Console.WriteLine("Dang dung...");
        }
    }
}
