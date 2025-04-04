using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle oto = new Car();
            oto.Move();
            oto.Stop();
            Vehicle xemay = new Motorcycle();
            xemay.Move();
            xemay.Stop();
        }
    }
}