using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNguoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p2 = new Student();
            p2.Speak();
            p2.Eat();
            ((Student)p2).Study();
            Person p3 = new Teacher();
            p3.Speak();
            p3.Eat();
            ((Teacher)p3).Teach();
        }
    }
}