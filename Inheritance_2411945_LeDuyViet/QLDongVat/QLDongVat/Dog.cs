using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog() { }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.Breed = breed;
        }

        public override void Speak()
        {
            Console.WriteLine("Gau gau");
        }
    }

}
