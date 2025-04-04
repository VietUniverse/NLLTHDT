using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongVat
{
	internal class Mouse:Animal
	{
		public float Weight { get; set; }
        public string KindOfFood { get; set; }

        public Mouse(string name, int age, float w, string food):base(name, age)
        {
            this.KindOfFood = food;
			this.Weight = w;	
        }
        public override void Speak()
		{
			base.Speak();
			Console.WriteLine("Chít chít");
		}

		public override string ToString()
		{
			return base.ToString() + "\t" + this.Weight + "\t" + this.KindOfFood;
		}
    }
}
