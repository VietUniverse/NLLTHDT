using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHinhHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape hTron = new Circle(4);
            Shape hChuNhat = new Rectangle(4,6);

            Console.WriteLine($"Dien tich hinh tron {hTron.Area()}");
            Console.WriteLine($"Chu vi hinh tron {hTron.Perimeter()}");
            hTron.Draw();
            Console.WriteLine($"Dien tich hinh chu nhat {hChuNhat.Area()}");
            Console.WriteLine($"Chu vi hinh chu nhat {hChuNhat.Perimeter()}");
            hChuNhat.Draw();
        }
    }
}