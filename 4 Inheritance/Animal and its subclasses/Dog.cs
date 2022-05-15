using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Animal_and_its_subclasses
{
    public class Dog :Mammal
    {
        public Dog(string name) : base(name) {}

        public void greets()
        {
            Console.WriteLine("Woof");
        }

        public void greets(Dog another)
        {
            Console.WriteLine("Wooooof");
        }

        public override string ToString()
        {
            return string.Format("Dog[{0}]", base.ToString());
        }

    }
}
