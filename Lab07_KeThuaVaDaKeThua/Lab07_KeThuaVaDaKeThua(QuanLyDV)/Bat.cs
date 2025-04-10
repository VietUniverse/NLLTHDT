using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_KeThuaVaDaKeThua_QuanLyDV_
{
    public class Bat : Animal, IFlyable
    {
        public Bat(string loai, string name, int age) : base(loai, name, age) { }

        public string Speak()
        {
            return "ec ec";
        }
        public string Move()
        {
            return "Dang di chuyen...";
        }
        public string Fly()
        {
            return "Dang bay...";
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", name, Fly());
        }
    }
}
