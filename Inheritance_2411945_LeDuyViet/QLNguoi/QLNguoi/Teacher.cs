using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNguoi
{

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher() { }
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.Subject = subject;
        }

        public override void Speak()
        {
            Console.WriteLine("Toi la giao vien");
        }

        public void Teach()
        {
            Console.WriteLine("Dang day...");
        }
    }
}
