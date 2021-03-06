using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._4_Inheritance.Animal_and_its_subclasses
{
    public class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("Animal[name={0}", name);
        }
    }
}
