using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab8_QuanLyXe
{
    internal interface IVehicle
    {
        public string Name { get; set; }
        public int TocDo {  get; set; }

        public void Chay();
        public void Dung();
    }
}
