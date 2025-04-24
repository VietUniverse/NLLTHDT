using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_KeThuaVaDaKeThua_QuanLyDV_
{
    public class Bird : Animal, IFlyable
    {
        public Bird() { }
        public Bird(string loai, string name, int age):base(loai, name, age) { }
        public string Speak()
        {
            return "chip chip";
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
            return string.Format("{0} {1}va keu {2}", name, Fly(), Speak());
        }
    }
}
