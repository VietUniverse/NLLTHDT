using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_KeThuaVaDaKeThua_QuanLyDV_
{
    interface IAnimal
    {
        string loai {  get; set; }
        string name {get; set;}
        int age { get; set; }

        string Speak(); //mặc định interface là public
    }
}
