using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongVat
{
	internal class Dog:Animal
	{
        public string Breed { get; set; }

        public Dog(string name, int  age, string breed):base(name, age)
        {
            this.Breed = breed;
        }
        public override void Speak()
		{
			base.Speak();
			Console.WriteLine("Gâu gâu");
		}

		public override string ToString()
		{
			return base.ToString() + "\t" + this.Breed;
		}
	}
}
