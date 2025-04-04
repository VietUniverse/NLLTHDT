using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Speak();
            Animal dog1 = new Dog();
            dog1.Speak();

        }
    }
}