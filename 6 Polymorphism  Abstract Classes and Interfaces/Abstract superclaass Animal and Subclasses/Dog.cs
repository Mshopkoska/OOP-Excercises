using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.Abstract_superclaass_Animal_and_Subclasses
{
    public class Dog : Animal
    {

        public Dog(string name) : base(name) { }
        
        public override void greets()
        {
            Console.WriteLine("Woof");
        }

        public void greets(Dog another)
        {
            Console.WriteLine("Woooof");
        }
    }
}
