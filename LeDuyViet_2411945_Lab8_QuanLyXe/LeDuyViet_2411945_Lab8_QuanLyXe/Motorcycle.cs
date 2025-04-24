using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab8_QuanLyXe
{
    internal class Motorcycle : Vehicle, IMotorcycle
    {
        public Motorcycle() { }
        public Motorcycle(string name, int tocDo) : base(name, tocDo)
        {
        }

        public void GiamToc()
        {
            TocDo = TocDo - 5;
        }

        public void TangToc()
        {
            TocDo = TocDo + 5;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
