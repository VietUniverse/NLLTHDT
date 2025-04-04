using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHinhHoc
{
    internal class Rectangle : Shape
    {
        double length;
        double height;

        public Rectangle(double length, double height)
        {
            this.length = length;
            this.height = height;
        }
        public override double Area()
        {
            return length * height;
        }

        public override double Perimeter()
        {
            return 2 * (length + height);
        }

        public override void Draw()
        {
            Console.WriteLine("Ve hinh chu nhat");
        }
    }
}
