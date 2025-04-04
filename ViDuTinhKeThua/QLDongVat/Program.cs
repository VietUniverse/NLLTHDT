using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongVat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DsDongVat ds = new DsDongVat();
			Animal a  = new Cat("Kitty", 2, "Trang");
			Animal b = new Dog("Kiki", 5, "Duc");
			Animal c = new Mouse("Jerry", 3, 0.2f, "Pho mai");
			//a.Speak();
			//b.Speak();
			//c.Speak();
			//a.Name = "kitty";
			//a.Age = 2;
			//((Cat)a).Color = "Den";
			//ds.Them(a);
			//ds.Them(b);
			//ds.Them(c);
			ds.DocTuFile("data.txt");
			ds.Xuat();

			Console.ReadKey();
		}
	}
}
