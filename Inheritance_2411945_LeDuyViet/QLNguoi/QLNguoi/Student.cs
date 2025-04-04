using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNguoi
{

    public class Student : Person
    {
        public string School { get; set; }

        public Student() { }

        public Student(string name, int age, string School) : base(name, age)
        {
            this.School = School;
        }

        public override void Speak()
        {
            Console.WriteLine("Toi la sinh vien");
        }


        public void Study()
        {
            Console.WriteLine("Dang hoc....");
        }
    }
}
