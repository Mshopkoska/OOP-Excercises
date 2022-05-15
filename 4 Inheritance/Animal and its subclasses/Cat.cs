using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Animal_and_its_subclasses
{
    public class Cat : Mammal
    {
        public Cat(string name) : base(name) { }

        public void greets() { Console.WriteLine("Meow"); }

        public override string ToString()
        {
            return string.Format("Cat[{0}]", base.ToString());
        }

    }
}
