using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNguoi
{


    public class Person
     {
        public string Name { get; set; }
        public int Age {  get; set; }

        public Person()
        { }

        public Person(string name, int age)
        {
            Name = name; Age = age;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Toi la nguoi...");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Dang an...");
        }
    }
}
