using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._6_Polymorphism__Abstract_Classes_and_Interfaces.Abstract_superclaass_Animal_and_Subclasses
{
    abstract public class Animal
    {
        protected string name;

        protected Animal(string name)
        {
            this.name = name;
        }

        abstract public void greets();
    }
}
