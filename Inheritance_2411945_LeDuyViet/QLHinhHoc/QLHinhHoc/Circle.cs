using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHinhHoc
{
    internal class Circle : Shape
    {
        double radius {  get; set; }

        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Ve hinh tron");
        }
    }
}
