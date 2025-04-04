using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHinhHoc
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();

        public Shape() { }

        public virtual void Draw()
        {
            Console.WriteLine("Ve hinh...");
        }
    }
}
