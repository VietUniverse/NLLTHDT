using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab8_QuanLyXe
{
    internal class Car : Vehicle, ICar
    {
        public int SoChoNgoi { get ; set ; }

        public Car() { }

        public Car(string ten, int tocDo, int scn) : base(ten, tocDo)
        {
            SoChoNgoi = scn;
        }

        public void DongCua()
        {
            if (SoChoNgoi <= 7)
            {
                SoChoNgoi = 0;
            }
        }

        public void MoCua()
        {
            if (SoChoNgoi > 7)
            {
                SoChoNgoi = 7;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("{0,5}", SoChoNgoi);
        }
    }
}
