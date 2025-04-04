using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongVat
{
	internal class Animal
	{
        public  string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Speak()
        {
            Console.Write("Thu dang keu .... ");
        }

		public override string ToString()
		{
			return string.Format("{0,-10}{1, -10}", Name, Age);
		}

	}
}
