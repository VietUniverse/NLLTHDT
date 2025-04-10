using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_KeThuaVaDaKeThua_QuanLyDV_
{
    public class Fish : Animal
    {
        public Fish(string loai, string name, int age) : base(loai, name, age) { }
        public string Speak()
        {
            return "...";
        }
        public string Move()
        {
            return "Dang boi...";
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", name, Move());
        }
    }
}
