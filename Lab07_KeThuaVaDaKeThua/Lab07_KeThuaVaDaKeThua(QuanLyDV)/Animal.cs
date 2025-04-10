using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_KeThuaVaDaKeThua_QuanLyDV_
{
    public class Animal : IAnimal,IMove 
    {
        public string loai {  get; set; }
        public string name { get; set; }
        public int age {  get; set; }
        public Animal(string loai, string name, int age)
        {
            this.loai = loai;
            this.name = name;
            this.age = age;
        }
        public string Speak()
        {
            return "dang keu...";
        }
        public string Move()
        {
            return "dang di chuyen...";
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", name, Move());
        }
    }
}
