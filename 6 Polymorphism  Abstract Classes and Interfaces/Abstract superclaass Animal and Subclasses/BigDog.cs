using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.Abstract_superclaass_Animal_and_Subclasses
{
    public class BigDog : Dog
    {
        public BigDog(string name) : base(name)
        {
        }

        public override void greets()
        {
            Console.WriteLine("Wooow");
        }

        public void greets(Dog another)
        {
            Console.WriteLine("Woooooow");
        }

        public void greets(BigDog another)
        {
            Console.WriteLine("Woooooooooow");
        }
    }
}
