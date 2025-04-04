using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongVat
{
	internal class Cat:Animal
	{
        public string Color { get; set; }

        public Cat(string name, int age, string color):base(name, age)
        {
            Color = color;
        }
        public override void Speak()
		{
			base.Speak();
			Console.WriteLine("Meo meo");
		}

        public override string ToString() {
            return base.ToString() + "\t" + Color;
        }
    }
}
