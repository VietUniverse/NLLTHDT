using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab8_QuanLyXe
{
    internal interface ICar
    {
        public int SoChoNgoi {  get; set; }

        public void DongCua();
        public void MoCua();
    }
}
