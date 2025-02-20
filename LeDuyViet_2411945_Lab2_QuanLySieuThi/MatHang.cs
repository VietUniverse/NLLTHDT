using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyViet_2411945_Lab2_QuanLySieuThi
{
    internal class MatHang
    {
        public string Id;
        public string Name;
        public string Unit;
        public float Price;

        public MatHang(string id, string name, string unit, float price)
        {
            Id = id;
            Name = name;
            Unit = unit;
            Price = price;
        }
        
    }
}
