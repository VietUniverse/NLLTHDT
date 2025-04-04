using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDongVat
{
	internal class DsDongVat
	{
		public List<Animal> animals;

        public DsDongVat()
        {
            animals = new List<Animal>();
        }

        public void Them(Animal animal)
        { 
            animals.Add(animal);
        }
        public void Xuat()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        public void DocTuFile(string tenFile)
        {
            StreamReader sr = new StreamReader(tenFile);
            string s = "";
            Animal a;
            while ((s = sr.ReadLine()) != null)
            {
                var line = s.Split('^');
                var name = line[1];
                var age = Convert.ToInt32(line[2]);
                if (line[0] == "M")
                    a = new Mouse(name, age, float.Parse(line[3].ToString()), line[4].ToString());
                else if (line[0] == "D")
                    a = new Dog(name, age, line[3].ToString());
                else
                    a = new Cat(name, age, line[3].ToString());
                Them(a);
            }
            sr.Close();
        }
    }
}
