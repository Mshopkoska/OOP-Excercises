using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Animal_and_its_subclasses
{
    public class Mammal : Animal
    {
        public Mammal(string name) : base(name) { }

        public override string ToString()
        {
            return string.Format("Mammal[{0}]", base.ToString());
        }


    }
}
