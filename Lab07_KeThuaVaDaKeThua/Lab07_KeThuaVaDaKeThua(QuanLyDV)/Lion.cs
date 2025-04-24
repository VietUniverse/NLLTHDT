using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_KeThuaVaDaKeThua_QuanLyDV_
{
    public class Lion : Animal
    {
        public Lion() { }

        public Lion(string loai, string name, int age) : base(loai, name, age)
        { }
        public string Speak()
        {
            return "Meo meo...";
        }
        public string Move()
        {
            return "Dang chay...";
        }

        public override string ToString()
        {
            return string.Format("{0} dang keu {1}", name, Speak());
        }
    }
}
